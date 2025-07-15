using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MyLittleWorld
{
    public class Fir : AbstractRadialObject
    {
        public Fir(PointF position, Point planetCenter, int planetRadius)
            : base(position, planetCenter, planetRadius)
        {
            ValidatePosition();
        }

        public override void Draw(Graphics g)
        {
            float angle = GetAngle();
            float width = 30;  // Ширина основания ели
            float height = 80; // Общая высота ели

            // Создаем ярусы ели 
            PointF[] bottomTier = CreateTier(Position, width * 0.9f, height * 0.4f, 6);
            PointF[] middleTier = CreateTier(Position, width * 0.7f, height * 0.3f, height * 0.35f);
            PointF[] topTier = CreateTier(Position, width * 0.4f, height * 0.3f, height * 0.6f);

            // Ствол 
            float trunkWidth = width * 0.1f;
            PointF[] trunk = new PointF[]
            {
                new PointF(Position.X - trunkWidth/2, Position.Y),
                new PointF(Position.X - trunkWidth/2, Position.Y - height * 0.1f),
                new PointF(Position.X + trunkWidth/2, Position.Y - height * 0.1f),
                new PointF(Position.X + trunkWidth/2, Position.Y)
            };

           

            // Поворачиваем все элементы
            PointUtils.RotatePoints(Position, bottomTier, angle);
            PointUtils.RotatePoints(Position, middleTier, angle);
            PointUtils.RotatePoints(Position, topTier, angle);
            PointUtils.RotatePoints(Position, trunk, angle);

            // Рисуем в правильном порядке
            DrawTrunk(g, trunk);
            DrawTier(g, bottomTier, Color.DarkGreen, Color.ForestGreen);
            DrawTier(g, middleTier, Color.ForestGreen, Color.LimeGreen);
            DrawTier(g, topTier, Color.LimeGreen, Color.LightGreen);
           
        }

        private PointF[] CreateTier(PointF baseCenter, float width, float height, float yOffset)
        {
            return new PointF[]
            {
                new PointF(baseCenter.X - width/2, baseCenter.Y - yOffset),
                new PointF(baseCenter.X, baseCenter.Y - height - yOffset),
                new PointF(baseCenter.X + width/2, baseCenter.Y - yOffset)
            };
        }

        

        private void DrawTier(Graphics g, PointF[] tier, Color startColor, Color endColor)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                tier[1], // Верхняя точка
                new PointF(tier[1].X, (tier[0].Y + tier[1].Y) / 2),
                startColor,
                endColor))
            {
                g.FillPolygon(brush, tier);
            }

            // Контур яруса
            using (Pen pen = new Pen(Color.DarkOliveGreen, 1))
            {
                g.DrawPolygon(pen, tier);
            }
        }

        private void DrawTrunk(Graphics g, PointF[] trunk)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                new PointF(trunk[1].X, trunk[1].Y),
                new PointF(trunk[0].X, trunk[0].Y),
                Color.SaddleBrown,
                Color.Brown))
            {
                g.FillPolygon(brush, trunk);
            }
        }

    }
}