using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace MyLittleWorld
{
    public class Planet
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
        public Color PlanetColor { get; set; } = Color.Green;
        private List<AbstractRadialObject> objects = new List<AbstractRadialObject>();

        public Planet(int centerX, int centerY, int radius)
        {
            Center = new Point(centerX, centerY);
            Radius = radius;
        }

        public void Draw(Graphics g, Bitmap texture, float rotationAngle)
        {
            GraphicsState state = g.Save();

            g.TranslateTransform(Center.X, Center.Y);

            g.RotateTransform(rotationAngle * (180f / (float)Math.PI)); // преобразуем радианы в градусы

            // Возвращаем начало координат обратно
            g.TranslateTransform(-Center.X, -Center.Y);
            // Создаем круглую маску
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);

            // Устанавливаем область отсечения
            Region oldRegion = g.Clip;
            g.SetClip(path, CombineMode.Replace);

            // Рисуем текстуру
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
            DrawAdvancedAtmosphere(g);
            // Восстанавливаем область отсечения
            g.Clip = oldRegion;

            // Рисуем контур планеты
            using (Pen outlinePen = new Pen(Color.Black, 0.1f))
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
           
            g.Restore(state);
        }


        public void AddObject(AbstractRadialObject obj)
        {
            objects.Add(obj);
        }

        public void ClearObjects()
        {
            objects.Clear();
        }

        public bool IsPointOnPlanet(PointF point)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - Center.X, 2) + Math.Pow(point.Y - Center.Y, 2));
            // Проверяем, что точка находится точно на границе (с небольшим допуском)
            return Math.Abs(distance - Radius) <= 3; // 3 пикселя допуск
        }
        public PointF AdjustPositionToSurface(PointF point, float rotationAngle)
        {
            float dx = point.X - Center.X;
            float dy = point.Y - Center.Y;
            float distance = (float)(Math.Sqrt(dx * dx + dy * dy));

            float angle = (float)Math.Atan2(point.Y - Center.Y, point.X - Center.X);
            float new_angle = angle - rotationAngle;
            PointF new_point = new PointF(Center.X + distance * (float)Math.Cos(new_angle), Center.Y + distance * (float)Math.Sin(new_angle));
            // Вектор от центра к точке


            // Длина вектора
            double _dx = new_point.X - Center.X;
            double _dy = new_point.Y - Center.Y;
            double _distance = Math.Sqrt(_dx * _dx + _dy * _dy);

            // Нормализуем вектор и умножаем на радиус
            double scale = Radius / _distance;
            return new PointF(
                (int)(Center.X + _dx * scale),
                (int)(Center.Y + _dy * scale)
            );
        }



        public void DrawAdvancedAtmosphere(Graphics g)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(
                Center.X - Radius - 20,
                Center.Y - Radius - 20,
                (Radius + 20) * 2,
                (Radius + 20) * 2);

            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            pthGrBrush.CenterPoint = Center;
            pthGrBrush.CenterColor = Color.FromArgb(50, 70, 130, 230);

            Color[] colors = { Color.FromArgb(150, 70, 130, 230) };
            pthGrBrush.SurroundColors = colors;

            g.FillEllipse(pthGrBrush,
                Center.X - Radius - 20,
                Center.Y - Radius - 20,
                (Radius + 20) * 2,
                (Radius + 20) * 2);
        }

        public Type DeleteObject(PointF point)
        {
            for (int i = objects.Count - 1; i >= 0; i--)
            {
                if (objects[i].IsPointOnObject(point))
                {
                    AbstractRadialObject drawable = objects[i];
                    objects.RemoveAt(i);
                    return drawable.GetType();
                }
            }
            return null;
        }

        public void ChangeCenter(int CenterX, int CenterY)
        {
            float dx = Center.X - CenterX;
            float dy = Center.Y - CenterY;
            Center = new Point(CenterX, CenterY);
            for (int i = objects.Count - 1; i >= 0; i--)
            {
                PointF newPos = new PointF(objects[i].Position.X - dx, objects[i].Position.Y - dy);
                objects[i].Position = newPos;
                objects[i].PlanetCenter = Center;
            }
        }

        public void ChangeRadius(int newRadius)
        {
            float scaleFactor = (float)newRadius / Radius; // Коэффициент масштабирования

            for (int i = objects.Count - 1; i >= 0; i--)
            {
                PointF oldPos = objects[i].Position;

                // Смещаем координаты относительно центра
                float relativeX = oldPos.X - Center.X;
                float relativeY = oldPos.Y - Center.Y;

                // Масштабируем
                PointF newPos = new PointF(
                    Center.X + relativeX * scaleFactor,
                    Center.Y + relativeY * scaleFactor
                );

                objects[i].Position = newPos;
            }

            Radius = newRadius; // Обновляем радиус в конце
        }
    }
}