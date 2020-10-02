using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kgFirst
{
    class Second
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
        public int Ipart(double x)
        {
            return (int)x;
        }

        public int Round(double x)
        {
            return Ipart(x + 0.5);
        }


        /// <summary>
        /// Дробная часть
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public double FPart(double x)

        {
            return  x-(int)x;
        }

        public void Plot(Graphics g,int x,int y,int len )
        {
            g.FillRectangle(Brushes.Black, new Rectangle(x, y, len, len));
        }

        public void ByDrawLine(Graphics g,float x1,float y1,float x2,float y2)
        {
            if(x2<x1)
            {
                Swap(ref x1,ref x2);
                Swap(ref y1,ref y2);
            }
            float dx = x2 - x1;
            float dy = y2 - y1;
            float gradient = dy / dx;

            float xend = Round(x1);
            float yend = y1 + gradient * (xend - x1);
            double xgap = 1 - FPart(x1 + 0.5);
            float xpxl1 = xend;
            float ypxl1 = Ipart(yend);
            Plot(g, (int)xpxl1, (int)ypxl1, (int)(1 - FPart(yend) * xgap));
            Plot(g, (int)xpxl1+1, (int)ypxl1, (int)(1 - FPart(yend) * xgap));
            float intery = yend + gradient;
            xend = Round(x2);
            yend = y2 + gradient * (xend - x2);
            xgap = FPart(x2 + 0.5);
            float xpxl2 = xend;
            float ypxl2 = Ipart(yend);
            Plot(g, (int)xpxl2, (int)ypxl2, (int)(1 - FPart(yend) * xgap));
            Plot(g, (int)xpxl2, (int)ypxl2+1, (int)(1 - FPart(yend) * xgap));
            for(int i=(int)(xpxl1+1);i<xpxl2;i++)
            {
                Plot(g,i, Ipart(intery),(int)( 1 - FPart(intery)));
                Plot(g,i, Ipart(intery) + 1,(int) FPart(intery));
                intery = intery + gradient;
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
