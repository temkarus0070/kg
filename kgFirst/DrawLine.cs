using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kgFirst
{
    class DrawLine
    {
        public static void DDA(Graphics g,int x1, int y1, int x2, int y2)
        {
            float L = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            float dx = (x2 - x1) / L;
            float dy = (y2 - y1) / L;
            float x = x1;
            float y = y1;
            for (int i = 0; i <= L; i++)
            {
                x += dx;
                y += dy;
                g.FillRectangle(Brushes.Black, x, y, 1, 1);
            }
        }


        public static void Brezhenheim(Graphics g,int x1, int y1, int x2, int y2)
        {
            int x = x1;
            int y = y1;
            int deltaX = x2 - x1;
            int deltaY = y2 - y1;
            float e = (deltaY / deltaX) -0.5f;
            for (int i=1;i<deltaX;i++)
            {
                
                g.FillRectangle(Brushes.Black, x, y, 1, 1);
                while(e>=0)
                {
                    y = y + 1;
                    e = e - 1;
                }
                x = x + 1;
                e = e + deltaY / deltaX;
            }


        }


        public static void By(Graphics g, int x1, int y1, int x2, int y2)
        {
            var step = Math.Abs(y2 - y1) > Math.Abs(x2 - x1);
            if(step)
            {

            }
        }

        /// <summary>
        /// Целая часть
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int ipart(double x)
        {
            return (int)x;
        }

        public int Round(double x)
        {
            return ipart(x + 0.5);
        }


        /// <summary>
        /// Дробная часть
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double fpart(double x)

        {
            if (x < 0)
                return (1 - (x - Math.Floor(x)));
            return (x - Math.Floor(x));
        }

        public double rfpart(double x)
        {
            return 1 - fpart(x);
        }

        public void Plot(Graphics g,double x,double y,int len )
        {
            g.FillRectangle(Brushes.Black, new Rectangle((int)x, (int)y, len, len));
        }

        public void ByDrawLine(Graphics g,double x0, double y0, double x1, double y1)
        {
            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            double temp;
            if (steep)
            {
                temp = x0; x0 = y0; y0 = temp;
                temp = x1; x1 = y1; y1 = temp;
            }
            if (x0 > x1)
            {
                temp = x0; x0 = x1; x1 = temp;
                temp = y0; y0 = y1; y1 = temp;
            }

            double dx = x1 - x0;
            double dy = y1 - y0;
            double gradient = dy / dx;

            double xEnd = Round(x0);
            double yEnd = y0 + gradient * (xEnd - x0);
            double xGap = rfpart(x0 + 0.5);
            double xPixel1 = xEnd;
            double yPixel1 = ipart(yEnd);

            if (steep)
            {
                Plot(g, yPixel1, xPixel1, (int)(rfpart(yEnd) * xGap));
                Plot(g, yPixel1 + 1, xPixel1, (int)(fpart(yEnd) * xGap));
            }
            else
            {
                Plot(g, xPixel1, yPixel1, (int)(rfpart(yEnd) * xGap));
                Plot(g, xPixel1, yPixel1 + 1, (int)(rfpart(yEnd) * xGap));
            }
            double intery = yEnd + gradient;

            xEnd = Round(x1);
            yEnd = y1 + gradient * (xEnd - x1);
            xGap = fpart(x1 + 0.5);
            double xPixel2 = xEnd;
            double yPixel2 = ipart(yEnd);
            if (steep)
            {
                Plot(g, yPixel2, xPixel2, (int)(rfpart(yEnd) * xGap));
                Plot(g, yPixel2 + 1, xPixel2, (int)(fpart(yEnd) * xGap));
            }
            else
            {
                Plot(g, xPixel2, yPixel2, (int)(rfpart(yEnd) * xGap));
                Plot(g, xPixel2, yPixel2 + 1, (int)(rfpart(yEnd) * xGap));
            }

            if (steep)
            {
                for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                {
                    Plot(g, ipart(intery), x, (int)rfpart(intery));
                    Plot(g, ipart(intery) + 1, x, (int)fpart(intery));
                    intery += gradient;
                }
            }
            else
            {
                for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                {
                    Plot(g, x, ipart(intery), (int)rfpart(intery));
                    Plot(g, x, ipart(intery) + 1, (int)fpart(intery));
                    intery += gradient;
                }
            }
        }

        public void Swap(ref float one,ref float two)
        {
            var temp = one;
            one = two;
            two = temp;
            
        }
    }
}
