using System;
using System.Drawing;

namespace MyLittleWorld
{
    public abstract class AbstractRadialObject : IDrawable
    {
        protected Point Position { get; }
        protected Point PlanetCenter { get; }
        protected int PlanetRadius { get; }

        public AbstractRadialObject(Point position, Point planetCenter, int planetRadius)
        {
            Position = position;
            PlanetCenter = planetCenter;
            PlanetRadius = planetRadius;
        }

        public abstract void Draw(Graphics g);

        protected float GetAngle()
        {
            float dx = Position.X - PlanetCenter.X;
            float dy = Position.Y - PlanetCenter.Y;
            // Изменяем направление на противоположное (+ Math.PI)
            return (float)Math.Atan2(dy, dx) + (float)Math.PI;
        }

        protected void RotatePoints(PointF[] points, float angle)
        {
            float rotationAngle = angle - (float)Math.PI / 2;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = PointUtils.RotatePointAround(Position, points[i], rotationAngle);
            }
        }
        protected void ValidatePosition()
        {
            double distance = Math.Sqrt(Math.Pow(Position.X - PlanetCenter.X, 2) +
                             Math.Pow(Position.Y - PlanetCenter.Y, 2));

            if (Math.Abs(distance - PlanetRadius) > 7)
            {
                throw new ArgumentException("Object must be placed on planet surface");
            }
        }
    }
}