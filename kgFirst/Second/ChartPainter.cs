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
            int y1 = dy * 50 - 8;
            int y2 = dy * 50 + 8;
            int x1 = dx * 50 - 8;
            int x2 = dx * 50 + 8;

            for(int i=1;i<dx*100;i+=dx)
            {
                drawLine.ByDrawLine(g, i, y1, i, y2);

            }
            for(int i=1;i<dy*100;i+=dy)
            {
                drawLine.ByDrawLine(g, x1, i, x2, i);
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
