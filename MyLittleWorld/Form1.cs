using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace MyLittleWorld
{
    public partial class MainForm : Form
    {
        private Planet planet;
        private Bitmap planetTexture;
        private SoundManager soundManager;
        private Type currentObjectType = typeof(House);
        private Dictionary<Type, int> objectCounts = new Dictionary<Type, int>();
        private Color skyColor = Color.LightBlue;

        private float planetRotationAngle = 0f;
        private float rotationSpeed = 1f; // градусов в кадр
        private bool isRotating = false;
        private DateTime lastUpdateTime;

        public MainForm()
        {
            InitializeComponent();
            InitializeApplication();
        }

        private void InitializeApplication()
        {
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
                    // Create a default texture if file not found
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

            // Initialize planet
            planet = new Planet(pictureBox.Width / 2, pictureBox.Height / 2, Math.Min(pictureBox.Width, pictureBox.Height) / 2 - 100);

            // Initialize sound manager
            soundManager = new SoundManager();
            soundManager.LoadSound(typeof(House), "C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\h.wav");
            soundManager.LoadSound(typeof(Fir), "C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\t.wav");
            soundManager.LoadSound(typeof(Obelisk), "C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\o.wav");
            soundManager.LoadSound(typeof(Mountains), "C:\\Users\\User\\source\\repos\\MyLittleWorld\\MyLittleWorld\\Resources\\m.wav");

            // Initialize object counts
            objectCounts[typeof(House)] = 0;
            objectCounts[typeof(Fir)] = 0;
            objectCounts[typeof(Obelisk)] = 0;
            objectCounts[typeof(Mountains)] = 0;

            // Set custom cursor
            this.Cursor = Cursors.Hand;

            // Set form icon
            this.Icon = SystemIcons.Warning;

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

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw sky with hatch brush
            Rectangle skyRect = new Rectangle(0, 0, pictureBox.Width, pictureBox.Height);
            using (var skyBrush = new System.Drawing.Drawing2D.HatchBrush(
                System.Drawing.Drawing2D.HatchStyle.LargeConfetti, skyColor, Color.AliceBlue))
            {
                g.FillRectangle(skyBrush, skyRect);
            }

            // Draw planet
            planet.Draw(g, planetTexture);
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // Корректируем позицию на поверхность планеты
            Point surfacePoint = planet.AdjustPositionToSurface(e.Location);

            if (planet.IsPointOnPlanet(surfacePoint))
            {
                IDrawable newObject = DrawableObjectsStaticFactory.CreateObject(
                    currentObjectType, surfacePoint, planet.Center, planet.Radius);

                planet.AddObject(newObject);
                objectCounts[currentObjectType]++;
                soundManager.PlaySound(currentObjectType);

                UpdateCounts();
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (planet.IsPointOnPlanet(e.Location))
            {
                Point surfacePoint = planet.AdjustPositionToSurface(e.Location);
                // Можно добавить визуальную подсказку (например, временный маркер)
            }
            pictureBox.Invalidate();
        }

        private void UpdateCounts()
        {
            lblHouseCount.Text = $"Домик: {objectCounts[typeof(House)]}";
            lblFirCount.Text = $"Елка: {objectCounts[typeof(Fir)]}";
            lblObeliskCount.Text = $"Обелиск: {objectCounts[typeof(Obelisk)]}";
            lblMountainsCount.Text = $"Гора: {objectCounts[typeof(Mountains)]}";
        }

        private void radioHouse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioHouse.Checked) currentObjectType = typeof(House);
        }

        private void radioFir_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFir.Checked) currentObjectType = typeof(Fir);
        }

        private void radioObelisk_CheckedChanged(object sender, EventArgs e)
        {
            if (radioObelisk.Checked) currentObjectType = typeof(Obelisk);
        }

        private void radioMountains_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMountains.Checked) currentObjectType = typeof(Mountains);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                skyColor = colorDialog.Color;
                pictureBox.Invalidate();
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
            pictureBox.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            planet.Radius = trackBar1.Value;
            planet.ClearObjects();
            objectCounts[typeof(House)] = 0;
            objectCounts[typeof(Fir)] = 0;
            objectCounts[typeof(Obelisk)] = 0;
            objectCounts[typeof(Mountains)] = 0;
            UpdateCounts();
            pictureBox.Invalidate();
        }
    }
}