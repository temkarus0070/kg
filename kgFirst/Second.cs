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
    }
}
