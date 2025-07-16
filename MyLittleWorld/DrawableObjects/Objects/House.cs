using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MyLittleWorld
{
    public class House : AbstractRadialObject
    {
        public House(PointF position, PointF planetCenter, int planetRadius)
            : base(position, planetCenter, planetRadius)
        {
            ValidatePosition();
        }

        public override void Draw(Graphics g)
        {
            float angle = GetAngle();
            float width = 20;
            float height = 17;

            PointF[] foundation = new PointF[]
            {
                new PointF(Position.X - width/2, Position.Y),
                new PointF(Position.X - width/2, Position.Y - height),
                new PointF(Position.X + width/2, Position.Y - height),
                new PointF(Position.X + width/2, Position.Y)
            };

            float roofHeight = height * 0.5f;
            PointF[] roof = new PointF[]
            {
                new PointF(Position.X - width/2, Position.Y - height),
                new PointF(Position.X + width/2, Position.Y - height),
                new PointF(Position.X, Position.Y - height - roofHeight)
            };

            float doorWidth = width * 0.3f;
            float doorHeight = height * 0.4f;
            PointF[] door = new PointF[]
            {
                new PointF(Position.X - doorWidth/2, Position.Y),
                new PointF(Position.X - doorWidth/2, Position.Y - doorHeight),
                new PointF(Position.X + doorWidth/2, Position.Y - doorHeight),
                new PointF(Position.X + doorWidth/2, Position.Y)
            };

            float windowSize = width * 0.25f;
            PointF[] window = new PointF[]
            {
                new PointF(Position.X - windowSize/2, Position.Y - height * 0.6f),
                new PointF(Position.X - windowSize/2, Position.Y - height * 0.8f),
                new PointF(Position.X + windowSize/2, Position.Y - height * 0.8f),
                new PointF(Position.X + windowSize/2, Position.Y - height * 0.6f)
            };

            // Поворачиваем все элементы
            PointUtils.RotatePoints(Position, foundation, angle);
            PointUtils.RotatePoints(Position, roof, angle);
            PointUtils.RotatePoints(Position, door, angle);
            PointUtils.RotatePoints(Position, window, angle);

            // Рисуем дом
            DrawFoundation(g, foundation);
            DrawRoof(g, roof);
            DrawDoor(g, door);
            DrawWindow(g, window);
        }

        private void DrawFoundation(Graphics g, PointF[] foundation)
        {
            using (SolidBrush brush = new SolidBrush(Color.SandyBrown))
            {
                g.FillPolygon(brush, foundation);
            }

            using (Pen pen = new Pen(Color.Brown, 2))
            {
                g.DrawPolygon(pen, foundation);
            }
        }

        private void DrawRoof(Graphics g, PointF[] roof)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                roof[0],
                roof[2],
                Color.DarkRed,
                Color.IndianRed))
            {
                g.FillPolygon(brush, roof);
            }

            using (Pen pen = new Pen(Color.DarkRed, 2))
            {
                g.DrawPolygon(pen, roof);
            }
        }

        private void DrawDoor(Graphics g, PointF[] door)
        {
            using (SolidBrush brush = new SolidBrush(Color.Brown))
            {
                g.FillPolygon(brush, door);
            }

           
            using (Pen pen = new Pen(Color.Brown, 1))
            {
                g.DrawPolygon(pen, door);
            }
        }

        private void DrawWindow(Graphics g, PointF[] windowFrame)
        {
            float angle = GetAngle();

            using (SolidBrush frameBrush = new SolidBrush(Color.White))
            {
                g.FillPolygon(frameBrush, windowFrame);
            }

            float glassMargin = (windowFrame[1].X - windowFrame[0].X) * 0.1f; // 10% отступа
            PointF[] glass = new PointF[]
            {
                new PointF(windowFrame[0].X + glassMargin, windowFrame[0].Y - glassMargin),
                new PointF(windowFrame[1].X + glassMargin, windowFrame[1].Y - glassMargin),
                new PointF(windowFrame[2].X - glassMargin, windowFrame[2].Y + glassMargin),
                new PointF(windowFrame[3].X - glassMargin, windowFrame[3].Y + glassMargin)
            };

            using (PathGradientBrush glassBrush = new PathGradientBrush(glass))
            {
                glassBrush.CenterColor = Color.LightSkyBlue;
                glassBrush.SurroundColors = new Color[] { Color.SkyBlue, Color.SkyBlue, Color.SkyBlue, Color.SkyBlue };
                g.FillPolygon(glassBrush, glass);
            }

           

            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                g.DrawPolygon(pen, windowFrame);
            }
        }
    }
}