using System;
using System.Drawing;

namespace MyLittleWorld
{
    public static class PointUtils
    {
        public static PointF RotatePointAround(PointF center, PointF point, float angle)
        {
            // Translate point to origin
            float translatedX = point.X - center.X;
            float translatedY = point.Y - center.Y;

            // Rotate point
            float rotatedX = translatedX * (float)Math.Cos(angle) - translatedY * (float)Math.Sin(angle);
            float rotatedY = translatedX * (float)Math.Sin(angle) + translatedY * (float)Math.Cos(angle);

            // Translate point back
            return new PointF(rotatedX + center.X, rotatedY + center.Y);
        }

        public static RectangleF RotateRectangleAround(PointF center, RectangleF rect, float angle)
        {
            PointF topLeft = new PointF(rect.Left, rect.Top);
            PointF topRight = new PointF(rect.Right, rect.Top);
            PointF bottomLeft = new PointF(rect.Left, rect.Bottom);
            PointF bottomRight = new PointF(rect.Right, rect.Bottom);

            PointF rotatedTopLeft = RotatePointAround(center, topLeft, angle);
            PointF rotatedTopRight = RotatePointAround(center, topRight, angle);
            PointF rotatedBottomLeft = RotatePointAround(center, bottomLeft, angle);
            PointF rotatedBottomRight = RotatePointAround(center, bottomRight, angle);

            // Find bounding rectangle
            float minX = Math.Min(Math.Min(rotatedTopLeft.X, rotatedTopRight.X), Math.Min(rotatedBottomLeft.X, rotatedBottomRight.X));
            float maxX = Math.Max(Math.Max(rotatedTopLeft.X, rotatedTopRight.X), Math.Max(rotatedBottomLeft.X, rotatedBottomRight.X));
            float minY = Math.Min(Math.Min(rotatedTopLeft.Y, rotatedTopRight.Y), Math.Min(rotatedBottomLeft.Y, rotatedBottomRight.Y));
            float maxY = Math.Max(Math.Max(rotatedTopLeft.Y, rotatedTopRight.Y), Math.Max(rotatedBottomLeft.Y, rotatedBottomRight.Y));

            return new RectangleF(minX, minY, maxX - minX, maxY - minY);
        }
    }
}