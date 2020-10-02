using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;

        private void Draw()

        {


          
            this.DoubleBuffered = true;
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(100, 100));
            g.DrawEllipse(Pens.Black, 10, 10, 200, 100);
            g.DrawLine(Pens.Pink, new Point(0, 0), new Point(100, 100));
            g.DrawArc(Pens.RosyBrown, new Rectangle(new Point(0, 0), new Size(100, 100)),3.14f,3);
            g.DrawBezier(Pens.RosyBrown, new Point(0, 0), new Point(50, 400), new Point(100, 560), new Point(500, 500));
            g.DrawRectangle(Pens.Aqua, rect);
            g.FillRectangle(Brushes.Cornsilk, rect);

        }

        private void DDA(int x1,int y1,int x2,int y2)
        {
            float L = Math.Max(Math.Abs(x2 - x1), Math.Abs(y2 - y1));
            float dx = (x2 - x1) / L;
            float dy = (y2 - y1) / L;
            float x = x1;
            float y = y1;
            for(int i=0;i<= L;i++)
            {
                x += dx;
                y += dy;
                g.FillRectangle(Brushes.Black, x, y, 1, 1);
            }
        }


        private void BRE(int x1,int y1,int x2,int y2)
        {
            float L = Math.Max(Math.Abs(x2 - x1), Math.Abs(x2 - x1));
            float sumError = 0;
            float error = Math.Abs((y2 - y1) / (x2 - x1));
            int thisY = y1;
            for(int i=x1;i<= x2;i++)
            {
                g.FillRectangle(Brushes.Black, i, thisY, 1, 1);
                sumError += error;
                if (error>=0.5)
                {
                    thisY++;
                    sumError--;

                }
               
            }
        }



        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.Clear(Color.White);
              Draw();

            //DDA(0, 0, 50, 50);
           // BRE(50, 50, 0, 0);
        }
    }
}
