using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MyLittleWorld
{
    public class Obelisk : AbstractRadialObject
    {
        public Obelisk(Point position, Point planetCenter, int planetRadius)
            : base(position, planetCenter, planetRadius)
        {
            ValidatePosition();
        }

        public override void Draw(Graphics g)
        {
            float angle = GetAngle();
            float width = 15;
            float height = 45;

            // Размеры компонентов
            float baseHeight = height * 0.2f;
            float pillarHeight = height * 0.6f;
            float pyramidHeight = height * 0.2f;
            float rayLength = pyramidHeight * 0.8f; // Уменьшенная длина лучей

            // 1. Основание
            PointF[] basePoints = new PointF[]
            {
                new PointF(Position.X - width/2, Position.Y),
                new PointF(Position.X - width/3, Position.Y - baseHeight),
                new PointF(Position.X + width/3, Position.Y - baseHeight),
                new PointF(Position.X + width/2, Position.Y)
            };

            // 2. Колонна
            float pillarTopWidth = width * 0.6f;
            PointF[] pillarPoints = new PointF[]
            {
                new PointF(Position.X - pillarTopWidth/2, Position.Y - baseHeight - pillarHeight),
                new PointF(Position.X + pillarTopWidth/2, Position.Y - baseHeight - pillarHeight),
                new PointF(Position.X + width/3, Position.Y - baseHeight),
                new PointF(Position.X - width/3, Position.Y - baseHeight)
            };

            // 3. Пирамида с лучами

            PointF[] pyramid = new PointF[]
            {
                new PointF(Position.X - pillarTopWidth/2, Position.Y - baseHeight - pillarHeight),
                new PointF(Position.X + pillarTopWidth/2, Position.Y - baseHeight - pillarHeight),
                new PointF(Position.X,  Position.Y - baseHeight - pillarHeight - pyramidHeight)
        };

            // 4. Лучи (12 лучей с меньшей длиной)
            PointF[] rayEnds = new PointF[12];
            for (int i = 0; i < 12; i++)
            {
                float rayAngle = i * (float)(2 * Math.PI / 12);
                rayEnds[i] = new PointF(
                    pyramid[2].X + rayLength * (float)Math.Cos(rayAngle),
                    pyramid[2].Y + rayLength * (float)Math.Sin(rayAngle));
            }

            // Поворот всех элементов
            RotatePoints(basePoints, angle);
            RotatePoints(pillarPoints, angle);
            RotatePoints(pyramid, angle);
            RotatePoints(rayEnds, angle);

            // Отрисовка
            DrawBase(g, basePoints);
            DrawPillar(g, pillarPoints);
            DrawPyramidWithRays(g, pyramid, rayEnds);
        }

    

        private void DrawBase(Graphics g, PointF[] basePoints)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                basePoints[0],
                basePoints[3],
                Color.DarkGray,
                Color.LightGray))
            {
                g.FillPolygon(brush, basePoints);
            }

            using (Pen pen = new Pen(Color.Black, 1))
            {
                g.DrawPolygon(pen, basePoints);
            }
        }

        private void DrawPillar(Graphics g, PointF[] pillarPoints)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new PointF(Position.X, pillarPoints[0].Y),
                new PointF(Position.X, pillarPoints[3].Y),
                Color.SlateGray,
                Color.LightGray))
            {
                g.FillPolygon(brush, pillarPoints);
            }

            using (Pen pen = new Pen(Color.Black, 1))
            {
                g.DrawPolygon(pen, pillarPoints);
            }
        }

        private void DrawPyramidWithRays(Graphics g, PointF[] pyramid, PointF[] rayEnds)
        {
            // Рисуем лучи (тонкие золотые линии)
            using (Pen rayPen = new Pen(Color.Gold, 1.5f))
            {
                foreach (PointF rayEnd in rayEnds)
                    g.DrawLine(rayPen, pyramid[2], rayEnd);
            }

            // Рисуем саму пирамиду

            using (LinearGradientBrush brush = new LinearGradientBrush(
                pyramid[0],
                pyramid[2],
                Color.Gold,
                Color.DarkGoldenrod))
            {
                g.FillPolygon(brush, pyramid);
            }

            // Блик на пирамиде
            PointF[] highlight = new PointF[]
            {
                new PointF(pyramid[0].X * 0.7f + pyramid[2].X * 0.3f,
                          pyramid[0].Y * 0.7f + pyramid[2].Y * 0.3f),
                new PointF(pyramid[1].X * 0.7f + pyramid[2].X * 0.3f,
                          pyramid[1].Y * 0.7f + pyramid[2].Y * 0.3f),
                pyramid[2]
            };

            using (SolidBrush highlightBrush = new SolidBrush(Color.FromArgb(180, Color.White)))
            {
                g.FillPolygon(highlightBrush, highlight);
            }

            using (Pen pen = new Pen(Color.Black, 1))
            {
                g.DrawPolygon(pen, pyramid);
            }
        }
    }
}