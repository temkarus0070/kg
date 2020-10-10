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



        public void ByDrawLine(Graphics g, int x1, int y1, int x2, int y2)
        {
            int x = x1;
            int y = y1;
            int Dx = x2 - x1;
            int Dy = y2 - y1;
            int e = 2 * Dy - Dx;
            float d;
            SolidBrush b1, b2;
            for (int i = 1; i <= Dx; i++)
            {
                d = -1F * e / (Dy + Dx) / 1.15F;
                if (e >= 0)
                {
                    
                    b1 = new SolidBrush(Color.Black);
                    b2 = new SolidBrush(Color.Black);
                    g.FillRectangle(Brushes.Black, x, y, 1, 1);
                    g.FillRectangle(Brushes.Black, x, y + 1, 1, 1);
                    y++;
                    e += -2 * Dx + 2 * Dy;
                }
                else
                {
                    b1 = new SolidBrush(Color.Black);
                    b2 = new SolidBrush(Color.Black);
                    g.FillRectangle(Brushes.Black, x, y, 1, 1);
                    g.FillRectangle(Brushes.Black, x, y - 1, 1, 1);
                    e += 2 * Dy;
                }
                x++;
                b1.Dispose();
                b2.Dispose();
            }
        }


    }
}
