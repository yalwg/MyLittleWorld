using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace MyLittleWorld
{
    public partial class MainForm : Form
    {
        private Planet planet;
        private Bitmap planetTexture;
        private SoundManager soundManager;
        private Type currentObjectType = typeof(House);

        private Dictionary<Type, int> objectCounts = new Dictionary<Type, int>();

        private Color skyColor1 = Color.LightBlue;
        private Color skyColor2 = Color.White;

        private Rectangle skyRect;
        private Timer timerRotation;
        private float planetRotationAngle = 0;
        private float rotationSpeed = 10; // градусов в кадр
        private bool isRotating = false;
        private DateTime lastUpdateTime;

        private bool isDeleteMode = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
            timerRotation = new Timer();
            timerRotation.Interval = 16; 
            timerRotation.Tick += timerRotation_Tick;

            btnColor1.ForeColor = Color.FromArgb(255 - skyColor1.R, 255 - skyColor1.G, 255 - skyColor1.B);
            btnColor1.BackColor = skyColor1;

            btnColor2.BackColor = skyColor2;
            btnColor2.ForeColor = Color.FromArgb(255 - skyColor2.R, 255 - skyColor2.G, 255 - skyColor2.B);

            try
            {
                string texturePath = Path.Combine("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\texture_2.png");
                if (File.Exists(texturePath))
                {
                    Bitmap originalTexture = new Bitmap(texturePath);
                    planetTexture = PreparePlanetTexture(originalTexture);
                }
                else
                {
                    planetTexture = CreateDefaultTexture();
                    MessageBox.Show("Текстура планеты не найдена. Используется текстура по умолчанию.",
                                  "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                planetTexture = CreateDefaultTexture();
                MessageBox.Show($"Ошибка загрузки текстуры: {ex.Message}. Используется текстура по умолчанию.",
                              "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            planet = new Planet(planetSystemPictureBox.Width / 2, planetSystemPictureBox.Height / 2, Math.Min(planetSystemPictureBox.Width, planetSystemPictureBox.Height) / 2 - 100);

            soundManager = new SoundManager();
            soundManager.LoadSound(typeof(House), "C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\h.wav");
            soundManager.LoadSound(typeof(Fir), "C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\t.wav");
            soundManager.LoadSound(typeof(Obelisk), "C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\o.wav");
            soundManager.LoadSound(typeof(Mountains), "C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\m.wav");

            objectCounts[typeof(House)] = 0;
            objectCounts[typeof(Fir)] = 0;
            objectCounts[typeof(Obelisk)] = 0;
            objectCounts[typeof(Mountains)] = 0;

            // Set form icon
            this.Icon = new Icon("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\earth.ico");

            // Set initial selection
            radioHouse.Checked = true;

            UpdateCounts();
        }

        private Bitmap PreparePlanetTexture(Bitmap originalTexture)
        {
            if (originalTexture == null)
                return null;

            // Создаем квадратную текстуру
            int size = Math.Max(originalTexture.Width, originalTexture.Height);
            Bitmap squareTexture = new Bitmap(size, size);

            using (Graphics g = Graphics.FromImage(squareTexture))
            {
                // Заливаем прозрачным цветом
                g.Clear(Color.Transparent);

                // Центрируем оригинальную текстуру
                int x = (size - originalTexture.Width) / 2;
                int y = (size - originalTexture.Height) / 2;

                g.DrawImage(originalTexture, x, y, originalTexture.Width, originalTexture.Height);
            }

            return squareTexture;
        }
        private Bitmap CreateDefaultTexture()
        {
            // Создаем простую текстуру по умолчанию
            Bitmap texture = new Bitmap(256, 256);
            using (Graphics g = Graphics.FromImage(texture))
            {
                using (var brush = new System.Drawing.Drawing2D.HatchBrush(
                    System.Drawing.Drawing2D.HatchStyle.LargeConfetti, Color.Green, Color.DarkGreen))
                {
                    g.FillRectangle(brush, 0, 0, texture.Width, texture.Height);
                }
            }
            return texture;
        }

        private Brush CreateImageSkyBrush(Bitmap textureImage)
        {
            return new TextureBrush(textureImage);
        }

        private Brush CreateHatchSkyBrush(Color mainColor, Color backColor)
        {
            return new System.Drawing.Drawing2D.HatchBrush(
                System.Drawing.Drawing2D.HatchStyle.LargeConfetti,
                mainColor,
                backColor);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            skyRect = new Rectangle(0, 0, planetSystemPictureBox.Width, planetSystemPictureBox.Height);

            Brush skyBrush;

            if (radioHatchBrush.Checked) // Если выбран паттерн
            {
                skyBrush = CreateHatchSkyBrush(skyColor1, skyColor2);
            }
            else // Если выбрано изображение
            {
                Bitmap skyImage = new Bitmap("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\texture_1.png"); // или загруженное из файла
                skyBrush = CreateImageSkyBrush(skyImage);
            }

            using (skyBrush)
            {
                g.FillRectangle(skyBrush, skyRect);
            }

            // Рисуем планету
            planet.Draw(g, planetTexture, planetRotationAngle);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            PointF surfacePoint = planet.AdjustPositionToSurface(e.Location, planetRotationAngle);
            if (!isDeleteMode)
            {
                // Корректируем позицию на поверхность планеты

                if (planet.IsPointOnPlanet(surfacePoint))
                {
                    AbstractRadialObject newObject = DrawableObjectsStaticFactory.CreateObject(
                        currentObjectType, surfacePoint, planet.Center, planet.Radius);

                    planet.AddObject(newObject);
                    objectCounts[currentObjectType]++;
                    soundManager.PlaySound(currentObjectType);

                    UpdateCounts();
                    planetSystemPictureBox.Invalidate();
                }
            }
            else
            {
                Type deleteType = planet.DeleteObject(surfacePoint);
                if (deleteType != null)
                {
                    objectCounts[deleteType]--;
                    UpdateCounts();
                    planetSystemPictureBox.Invalidate();
                }
            }

            

        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (planet.IsPointOnPlanet(e.Location))
            {
                PointF surfacePoint = planet.AdjustPositionToSurface(e.Location, planetRotationAngle);
            }
            planetSystemPictureBox.Invalidate();
        }

        private void UpdateCounts()
        {
            lblHouseCount.Text = $"Домик: {objectCounts[typeof(House)]}";
            lblFirCount.Text = $"Елка: {objectCounts[typeof(Fir)]}";
            lblObeliskCount.Text = $"Обелиск: {objectCounts[typeof(Obelisk)]}";
            lblMountainsCount.Text = $"Гора: {objectCounts[typeof(Mountains)]}";
        }

        [DllImport("user32.dll")]
        public static extern IntPtr LoadCursorFromFile(string filename);
        public void SetPictureBoxCursor(string path)
        {
            Cursor mycursor = new Cursor(Cursor.Current.Handle);
            IntPtr colorcursorhandle = LoadCursorFromFile(path);
            mycursor.GetType().InvokeMember("handle", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetField, null, mycursor, new object[] { colorcursorhandle });
            planetSystemPictureBox.Cursor = mycursor;
        }

        private void radioHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHouse.Checked)
            {
                currentObjectType = typeof(House);
                SetPictureBoxCursor("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\cur1.cur");
            }
        }

        private void radioFir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFir.Checked)
            {
                currentObjectType = typeof(Fir);
                SetPictureBoxCursor("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\cur2.cur");
            }
        }

        private void radioObelisk_CheckedChanged(object sender, EventArgs e)
        {
            if (radioObelisk.Checked)
            {
                currentObjectType = typeof(Obelisk);
                SetPictureBoxCursor("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\cur3.cur");
            }
        }

        private void radioMountains_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMountains.Checked)
            {
                currentObjectType = typeof(Mountains);
                SetPictureBoxCursor("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\cur4.cur");
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                skyColor1 = colorDialog.Color;
                btnColor1.BackColor = skyColor1;
                btnColor1.ForeColor = Color.FromArgb(255 - skyColor1.R, 255 - skyColor1.G, 255 - skyColor1.B);
                planetSystemPictureBox.Invalidate();
            }
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                skyColor2 = colorDialog.Color;
                btnColor2.BackColor = skyColor2;
                btnColor2.ForeColor = Color.FromArgb(255 - skyColor2.R, 255 - skyColor2.G, 255 - skyColor2.B);
                planetSystemPictureBox.Invalidate();
            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            planet.ClearObjects();
            objectCounts[typeof(House)] = 0;
            objectCounts[typeof(Fir)] = 0;
            objectCounts[typeof(Obelisk)] = 0;
            objectCounts[typeof(Mountains)] = 0;
            UpdateCounts();
            planetSystemPictureBox.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            planet.Radius = trackBarRadius.Value;
            planet.ClearObjects();
            objectCounts[typeof(House)] = 0;
            objectCounts[typeof(Fir)] = 0;
            objectCounts[typeof(Obelisk)] = 0;
            objectCounts[typeof(Mountains)] = 0;
            UpdateCounts();
            planetSystemPictureBox.Invalidate();
        }

        private void btnStartRotation_Click(object sender, EventArgs e)
        {
            isRotating = true;
            lastUpdateTime = DateTime.Now;
            timerRotation.Start();
        }

        private void btnStopRotation_Click(object sender, EventArgs e)
        {
            isRotating = false;
            timerRotation.Stop();
        }


        private void timerRotation_Tick(object sender, EventArgs e)
        {
            if (isRotating)
            {
                DateTime now = DateTime.Now;
                float deltaTime = (float)(now - lastUpdateTime).TotalSeconds;
                lastUpdateTime = now;

                planetRotationAngle += deltaTime * (float)(rotationSpeed * Math.PI / 180);
                

                planetSystemPictureBox.Invalidate();
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            rotationSpeed = trackBarSpeed.Value;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            boxSkyColor.Enabled = true;
            planetSystemPictureBox.Invalidate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            boxSkyColor.Enabled = false;
            planetSystemPictureBox.Invalidate();
        }

        private void buttonDeleteMode_Click(object sender, EventArgs e)
        {
            
            isDeleteMode = true;
            btnBuildMode.BackColor = Color.LightGray;
            btnDeleteMode.BackColor = Color.IndianRed;
            boxBuildMode.Enabled = false;
            planetSystemPictureBox.Cursor = Cursors.No;
        }

        private void buttonBuildMode_Click(object sender, EventArgs e)
        {
            isDeleteMode = false;
            btnBuildMode.BackColor = Color.LightGreen;
            btnDeleteMode.BackColor = Color.LightGray;
            planetSystemPictureBox.Cursor = Cursors.Hand;
            boxBuildMode.Enabled = true;
            if (radioHouse.Checked)
            {
                currentObjectType = typeof(House);
                SetPictureBoxCursor("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\cur1.cur");
            }
            if (radioFir.Checked)
            {
                currentObjectType = typeof(Fir);
                SetPictureBoxCursor("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\cur2.cur");
            }
            if (radioObelisk.Checked)
            {
                currentObjectType = typeof(Obelisk);
                SetPictureBoxCursor("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\cur3.cur");
            }
            if (radioMountains.Checked)
            {
                currentObjectType = typeof(Mountains);
                SetPictureBoxCursor("C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\cur4.cur");
            }
        }

        
    }
}