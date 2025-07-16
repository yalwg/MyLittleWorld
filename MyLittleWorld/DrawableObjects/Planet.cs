using MyLittleWorld.DrawableObjects.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace MyLittleWorld
{
    public class Planet : IDrawable
    {
        public PointF PlanetCenter { get; set; }
        public int Radius { get; set; }
        public float rotationAngle { get; set; }
        public Color PlanetColor { get; set; } = Color.Green;

        private List<IDrawableRadial> objects = new List<IDrawableRadial>();

        private Bitmap Texture;

        public Planet(int centerX, int centerY, int radius, Bitmap texture)
        {
            PlanetCenter = new Point(centerX, centerY);
            Radius = radius;
            Texture = texture;
        }

        public void Draw(Graphics g)
        {
            GraphicsState state = g.Save();

            g.TranslateTransform(PlanetCenter.X, PlanetCenter.Y);

            g.RotateTransform(rotationAngle * (180f / (float)Math.PI)); // преобразуем радианы в градусы

            // Возвращаем начало координат обратно
            g.TranslateTransform(-PlanetCenter.X, -PlanetCenter.Y);
            // Создаем круглую маску
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(PlanetCenter.X - Radius, PlanetCenter.Y - Radius, Radius * 2, Radius * 2);

            // Устанавливаем область отсечения
            Region oldRegion = g.Clip;
            g.SetClip(path, CombineMode.Replace);

            // Рисуем текстуру
            if (Texture != null)
            {
                Rectangle destRect = new Rectangle(
                    (int)PlanetCenter.X - Radius,
                    (int)PlanetCenter.Y - Radius,
                    Radius * 2,
                    Radius * 2);

                g.DrawImage(Texture, destRect);
                
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(PlanetColor))
                {
                    g.FillEllipse(brush,
                        PlanetCenter.X - Radius,
                        PlanetCenter.Y - Radius,
                        Radius * 2,
                        Radius * 2);
                }
            }
            DrawAdvancedAtmosphere(g);
            // Восстанавливаем область отсечения
            g.Clip = oldRegion;

            // Рисуем контур планеты



            using (Pen outlinePen = new Pen(Color.Black, 0.1f))
            {
                g.DrawEllipse(outlinePen,
                    PlanetCenter.X - Radius,
                    PlanetCenter.Y - Radius,
                    Radius * 2,
                    Radius * 2);
            }

            // Рисуем объекты на планете
            foreach (var obj in objects)
            {
                obj.Draw(g);
            }
           
            g.Restore(state);
        }


        public void AddObject(IDrawableRadial obj)
        {
            objects.Add(obj);
        }

        public void ClearObjects()
        {
            objects.Clear();
        }

        public bool IsPointOnObject(PointF point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - PlanetCenter.X, 2) + Math.Pow(point.Y - PlanetCenter.Y, 2));
            // Проверяем, что точка находится точно на границе (с небольшим допуском)
            return Math.Abs(distance - Radius) <= 3; // 3 пикселя допуск
        }



        public void DrawAdvancedAtmosphere(Graphics g)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(
                PlanetCenter.X - Radius - 20,
                PlanetCenter.Y - Radius - 20,
                (Radius + 20) * 2,
                (Radius + 20) * 2);

            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterPoint = PlanetCenter;
            pthGrBrush.CenterColor = Color.FromArgb(50, 70, 130, 230);

            Color[] colors = { Color.FromArgb(150, 70, 130, 230) };
            pthGrBrush.SurroundColors = colors;

            g.FillEllipse(pthGrBrush,
                PlanetCenter.X - Radius - 20,
                PlanetCenter.Y - Radius - 20,
                (Radius + 20) * 2,
                (Radius + 20) * 2);
        }

        public Type DeleteObject(PointF point)
        {
            for (int i = objects.Count - 1; i >= 0; i--)
            {
                if (objects[i].IsPointOnObject(point))
                {
                    IDrawableRadial drawable = objects[i];
                    objects.RemoveAt(i);
                    return drawable.GetType();
                }
            }
            return null;
        }

        public void ChangeCenter(int CenterX, int CenterY)
        {
            float dx = PlanetCenter.X - CenterX;
            float dy = PlanetCenter.Y - CenterY;
            PlanetCenter = new Point(CenterX, CenterY);
            for (int i = objects.Count - 1; i >= 0; i--)
            {
                PointF newPos = new PointF(objects[i].Position.X - dx, objects[i].Position.Y - dy);
                objects[i].Position = newPos;
                objects[i].PlanetCenter = PlanetCenter;
            }
        }

        public void ChangeRadius(int newRadius)
        {
            float scaleFactor = (float)newRadius / Radius; // Коэффициент масштабирования

            for (int i = objects.Count - 1; i >= 0; i--)
            {
                objects[i].Position = PointUtils.AdjustPositionToSurface(PlanetCenter, objects[i].Position, scaleFactor);
            }

            Radius = newRadius; // Обновляем радиус в конце
        }
    }
}