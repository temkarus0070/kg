using System;
using System.Drawing;

namespace kgFirst.Second
{
    public class Line
    {
        private double x0, y0, x1, y1;


        public Line(double x0, double y0, double x1, double y1)
        {
            this.x0 = x0;
            this.y0 = y0;
            this.y1 = y1;
            this.x1 = x1;


        }

        private void plot(Graphics graphics, double x, double y, double c)
        {
           
                graphics.FillRectangle(Brushes.Black, new RectangleF(new PointF((float)x, (float)y), new Size(1, 1)));
        }

        int ipart(double x) { return (int)x; }

        int round(double x) { return ipart(x + 0.5); }

        double fpart(double x)
        {
            if (x < 0) return (1 - (x - Math.Floor(x)));
            return (x - Math.Floor(x));
        }

        double rfpart(double x)
        {
            return 1 - fpart(x);
        }


        public void draw(Graphics graphics)
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

            double xEnd = round(x0);
            double yEnd = y0 + gradient * (xEnd - x0);
            double xGap = rfpart(x0 + 0.5);
            double xPixel1 = xEnd;
            double yPixel1 = ipart(yEnd);

            if (steep)
            {
                plot(graphics, yPixel1, xPixel1, rfpart(yEnd) * xGap);
                plot(graphics, yPixel1 + 1, xPixel1, fpart(yEnd) * xGap);
            }
            else
            {
                plot(graphics, xPixel1, yPixel1, rfpart(yEnd) * xGap);
                plot(graphics, xPixel1, yPixel1 + 1, fpart(yEnd) * xGap);
            }
            double intery = yEnd + gradient;

            xEnd = round(x1);
            yEnd = y1 + gradient * (xEnd - x1);
            xGap = fpart(x1 + 0.5);
            double xPixel2 = xEnd;
            double yPixel2 = ipart(yEnd);
            if (steep)
            {
                plot(graphics, yPixel2, xPixel2, rfpart(yEnd) * xGap);
                plot(graphics, yPixel2 + 1, xPixel2, fpart(yEnd) * xGap);
            }
            else
            {
                plot(graphics, xPixel2, yPixel2, rfpart(yEnd) * xGap);
                plot(graphics, xPixel2, yPixel2 + 1, fpart(yEnd) * xGap);
            }

            if (steep)
            {
                for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                {
                    plot(graphics, ipart(intery), x, rfpart(intery));
                    plot(graphics, ipart(intery) + 1, x, fpart(intery));
                    intery += gradient;
                }
            }
            else
            {
                for (int x = (int)(xPixel1 + 1); x <= xPixel2 - 1; x++)
                {
                    plot(graphics, x, ipart(intery), rfpart(intery));
                    plot(graphics, x, ipart(intery) + 1, fpart(intery));
                    intery += gradient;
                }
            }
        }
    }
}
