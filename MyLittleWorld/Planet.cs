using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

namespace MyLittleWorld
{
    public class Planet
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color PlanetColor { get; set; } = Color.Green;
        private List<IDrawable> objects = new List<IDrawable>();

        public Planet(int centerX, int centerY, int radius)
        {
            Center = new Point(centerX, centerY);
            Radius = radius;
        }

        public void Draw(Graphics g, Bitmap texture)
        {
            // Создаем круглую маску
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);

            // Устанавливаем область отсечения
            Region oldRegion = g.Clip;
            g.SetClip(path, CombineMode.Replace);

            // Рисуем текстуру (она будет обрезана по кругу)
            if (texture != null)
            {
                Rectangle destRect = new Rectangle(
                    Center.X - Radius,
                    Center.Y - Radius,
                    Radius * 2,
                    Radius * 2);

                g.DrawImage(texture, destRect);
            }
            else
            {
                using (SolidBrush brush = new SolidBrush(PlanetColor))
                {
                    g.FillEllipse(brush,
                        Center.X - Radius,
                        Center.Y - Radius,
                        Radius * 2,
                        Radius * 2);
                }
            }

            // Восстанавливаем область отсечения
            g.Clip = oldRegion;

            // Рисуем контур планеты
            using (Pen outlinePen = new Pen(Color.Black, 1))
            {
                g.DrawEllipse(outlinePen,
                    Center.X - Radius,
                    Center.Y - Radius,
                    Radius * 2,
                    Radius * 2);
            }

            // Рисуем объекты на планете
            foreach (var obj in objects)
            {
                obj.Draw(g);
            }
        }

        public void AddObject(IDrawable obj)
        {
            objects.Add(obj);
        }

        public void ClearObjects()
        {
            objects.Clear();
        }

        public bool IsPointOnPlanet(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2));
            // Проверяем, что точка находится точно на границе (с небольшим допуском)
            return Math.Abs(distance - Radius) <= 3; // 3 пикселя допуск
        }
        public Point AdjustPositionToSurface(Point point)
        {
            // Вектор от центра к точке
            double dx = point.X - Center.X;
            double dy = point.Y - Center.Y;

            // Длина вектора
            double distance = Math.Sqrt(dx * dx + dy * dy);

            // Нормализуем вектор и умножаем на радиус
            double scale = Radius / distance;
            return new Point(
                (int)(Center.X + dx * scale),
                (int)(Center.Y + dy * scale)
            );
        }
    }
}