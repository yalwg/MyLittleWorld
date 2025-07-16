using System;
using System.Drawing;

namespace MyLittleWorld
{
    public static class PointUtils
    {
        public static PointF RotatePointAround(PointF center, PointF point, float angle)
        {
            float translatedX = point.X - center.X;
            float translatedY = point.Y - center.Y;

            float rotatedX = translatedX * (float)Math.Cos(angle) - translatedY * (float)Math.Sin(angle);
            float rotatedY = translatedX * (float)Math.Sin(angle) + translatedY * (float)Math.Cos(angle);

            return new PointF(rotatedX + center.X, rotatedY + center.Y);
        }
        public static void RotatePoints(PointF center, PointF[] points, float angle)
        {
            float rotationAngle = angle - (float)Math.PI / 2;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = RotatePointAround(center, points[i], rotationAngle);
            }
        }

        public static PointF AdjustPositionToSurface(PointF center, PointF oldPos, float scaleFactor)
        {

            // Смещаем координаты относительно центра
            float dx = oldPos.X - center.X;
            float dy = oldPos.Y - center.Y;

            // Масштабируем
            return new PointF(
                center.X + dx * scaleFactor,
                center.Y + dy * scaleFactor
            );

        }

        public static PointF AdjustPositionToSurfaceInRotation(PointF center, PointF oldPos, int radius, float rotationAngle)
        {
            float dx = oldPos.X - center.X;
            float dy = oldPos.Y - center.Y;
            float distance = (float)(Math.Sqrt(dx * dx + dy * dy));

            float angle = (float)Math.Atan2(oldPos.Y - center.Y, oldPos.X - center.X);
            float newAngle = angle - rotationAngle;
            PointF newPos = new PointF(center.X + distance * (float)Math.Cos(newAngle), center.Y + distance * (float)Math.Sin(newAngle));
            // Вектор от центра к точке


            // Длина вектора
            double _dx = newPos.X - center.X;
            double _dy = newPos.Y - center.Y;
            double _distance = Math.Sqrt(_dx * _dx + _dy * _dy);

            // Нормализуем вектор и умножаем на радиус
            double scale = radius / _distance;
            return new PointF(
                (int)(center.X + _dx * scale),
                (int)(center.Y + _dy * scale)
            );
        }

    }
}