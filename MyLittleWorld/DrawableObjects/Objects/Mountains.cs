using System;
using System.Drawing;

namespace MyLittleWorld
{
    public class Mountains : AbstractRadialObject
    {
        public Mountains(PointF position, Point planetCenter, int planetRadius)
            : base(position, planetCenter, planetRadius) {
            ValidatePosition();
        }

        public override void Draw(Graphics g)
        {
            float angle = GetAngle();
            float width = 30;
            float height = 30;

            PointF[] mountains = new PointF[5];
            mountains[0] = new PointF(Position.X - width / 2, Position.Y + 1);
            mountains[1] = new PointF(Position.X - width / 4, Position.Y - height);
            mountains[2] = new PointF(Position.X, Position.Y - height * 0.8f);
            mountains[3] = new PointF(Position.X + width / 4, Position.Y - height * 2);
            mountains[4] = new PointF(Position.X + width / 2, Position.Y + 1);

            PointUtils.RotatePoints(Position, mountains, angle);

            using (SolidBrush brush = new SolidBrush(Color.DarkSlateGray))
            {
                using (var gradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    mountains[0], // Начальная точка градиента
                    mountains[4], // Конечная точка градиента
                    Color.Black,           // Начальный цвет
                    Color.Gray))         // Конечный цвет
                {
                    g.FillPolygon(gradientBrush, mountains);
                }
            }
        }
    }
}