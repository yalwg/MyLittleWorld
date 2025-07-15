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
                points[i] = PointUtils.RotatePointAround(center, points[i], rotationAngle);
            }
        }


    }
}