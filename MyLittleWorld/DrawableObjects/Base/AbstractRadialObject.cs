using MyLittleWorld.DrawableObjects.Base;
using System;
using System.Drawing;

namespace MyLittleWorld
{
    public abstract class AbstractRadialObject :IDrawableRadial
    {
        public PointF Position { get; set; }
        public PointF PlanetCenter { get; set; }
        public int PlanetRadius { get; set; }
        public AbstractRadialObject(PointF position, PointF planetCenter, int planetRadius)
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

  
        protected void ValidatePosition()
        {
            double distance = Math.Sqrt(Math.Pow(Position.X - PlanetCenter.X, 2) +
                             Math.Pow(Position.Y - PlanetCenter.Y, 2));

            if (Math.Abs(distance - PlanetRadius) > 7)
            {
                throw new ArgumentException("Object must be placed on planet surface");
            }
        }

        public bool IsPointOnObject(PointF point)
        {
            float distance = (float)Math.Sqrt(
                Math.Pow(point.X - Position.X, 2) +
                Math.Pow(point.Y - Position.Y, 2));

            return distance < 30;
        }

    }
}