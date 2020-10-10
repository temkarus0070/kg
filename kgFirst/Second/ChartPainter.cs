﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgFirst.Second
{
    class ChartPainter
    {
        private Size size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        private const int maxX = 50;
        private DrawLine drawLine = new DrawLine();
        public Function Function { get; set; }
        private int dx;
        private int dy;
        public void PrintCoordinateSystem(Graphics graphics)
        {

            var x1 = dx * 50;
            var y1 = 0;
            var x2 = dx * 50;
            var y2 = dy * 100;

            drawLine.ByDrawLine(graphics, x1, y1, x2, y2);
            drawLine.ByDrawLine(graphics, 0, dy * 50, dx * 100, dy * 50);
            PrintSecondLines(graphics);
            
        }

        public void PrintSecondLines(Graphics g)
        {
            Font font = new Font("Times New Roman", 8, FontStyle.Regular);
            int y1 = dy * 50 - 8;
            int y2 = dy * 50 + 8;
            int x1 = dx * 50 - 8;
            int x2 = dx * 50 + 8;
            int num = 0;
            int i;
            for (i = 1, num = -50; i < dx * 100; i += dx, num += 1)
            {

                drawLine.ByDrawLine(g, i, y1, i, y2);
                g.DrawString(num.ToString(), font, Brushes.Black, new PointF(i, y1 - 5));
            }
            for (i = 1, num = 50; i < dy * 100; i += dy, num -= 1)
            {
                drawLine.ByDrawLine(g, x1, i, x2, i);
                g.DrawString(num.ToString(), font, Brushes.Black, new PointF(x2 + 2, i));
            }

        }

        public PointF GetTruePoint(float x, float y)
        {
            PointF newPoint = new PointF(0, 0);
            if (x == 0)
            {
                newPoint.X = 50;
            }
            if (y == 0)
            {
                newPoint.Y = 50;
            }
            if (x < 0)
            {
                newPoint.X = (-50 - x) * -1;
            }
            if (x > 0)
            {
                newPoint.X = 50 + x;
            }
            if (y > 0)
            {
                newPoint.Y = (50 - y);
            }
            if (y < 0)
            {
                newPoint.Y = (50 + (-y));
            }
            newPoint.X *= dx;
            newPoint.Y *= dy;
            return newPoint;
        }

        public void PaintChart(Function.functionFromX function, Graphics graphics)
        {
            bool first = true;
            PointF point1 = new PointF();
            for (float x = -maxX; x <= maxX; x += 0.1f)
            {
                
                float y = function(x);
              
                if (first)
                {
                    point1 = GetTruePoint(x, y);
                    first = false;
                }
                else
                {

                    PointF point = GetTruePoint(x, y);
                    CallBy(graphics, point1, point);
                    point1 = point;
                }

            }
            graphics.Dispose();

        }



        public void CallBy(Graphics g, PointF p, PointF p1)
        {
            if (Math.Abs(p1.Y) <= size.Height && Math.Abs(p.Y) <= size.Height)
            {
                Line line = new Line(p.X, p.Y, p1.X, p1.Y, Color.Black, 0, 0);
                line.draw(g);
            }

        }



        public ChartPainter()
        {
            var ymax = Screen.PrimaryScreen.Bounds.Height;
            var xmax = Screen.PrimaryScreen.Bounds.Width;
            dx = xmax / 100;
            dy = ymax / 100;


        }
    }
}
