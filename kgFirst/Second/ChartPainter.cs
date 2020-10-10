using System;
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
                g.DrawString(num.ToString(), font, Brushes.Black, new PointF(i, y1-5));
            }
            for(i=1,num = 50;i<dy*100;i+=dy,num-=1)
            {
                drawLine.ByDrawLine(g, x1, i, x2, i);
                g.DrawString(num.ToString(),font, Brushes.Black, new PointF(x2 + 2, i));
            }

        }

        public Point GetTruePoint(int x,int y)
        {
            Point newPoint = new Point(0,0);
            if(x<0)
            {
                newPoint.X = Math.Abs(-50 + x);
            }
            if(x>0)
            {
                newPoint.X = 50 + x;
            }
            if(y>0)
            {
                newPoint.Y = (50 - y);
            }
            if(y<0)
            {
                newPoint.Y = (50 + (-y));
            }
            newPoint.X *= dx;
            newPoint.Y *= dy;
            return newPoint;
        }

        public void PaintChart(Function.functionFromX function,Graphics graphics)
        {
           
            List<Point> list = new List<Point>();
            bool first = true;
            Point point1 = new Point();
            for(int x=-50;x<=50;x++)
            {
                double y = function(x);
                if (first)
                {
                    point1 = GetTruePoint(x, (int)y);
                    first = false;
                }
                else
                {

                    Point point = GetTruePoint(x, (int)y);
                    if(GetDistanceBetweenPoints(point1,point)>=3)
                    {
                        CallBy(graphics, point1, point);
                        list.Add(point1);
                        list.Add(point);
                        point1 = point;
                    }
                 
                }

            }
           
        }

        public double GetDistanceBetweenPoints(Point first,Point second)
        {
            return Math.Sqrt((second.X - first.X) * (second.X - first.X) + (second.Y - first.Y) * (second.Y - first.Y));
        }

        public void CallBy(Graphics g,Point p,Point p1)
        {
            drawLine.ByDrawLine(g, p.X, p.Y, p1.X, p1.Y);
        }

        public Point CallGetPointer(Point p)
        {
            return GetTruePoint(p.X, p.Y);
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
