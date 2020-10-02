﻿using System;
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
           // Second.Brezhenheim(g, 0, 0, 500, 500);
          //  Second.DDA( g, 0, 0, 900, 900);

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

        }

        private void DdaBtn_Click(object sender, EventArgs e)
        {
            this.Paint += ActiveForm_Paint;
            this.Invalidate();
            this.Update();
         
           
       
        }

        private void ActiveForm_Paint(object sender, PaintEventArgs e)
        {

            g.Clear(Color.White);
            Second.DDA(g, 0, 0, 500, 500);
        }

        private void brzBtn_Click(object sender, EventArgs e)
        {
            this.Paint += Form1_Paint;
            this.Invalidate();
            this.Update();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            Second.Brezhenheim(g, 50, 50, 500, 500);
        }

        private void byBtn_Click(object sender, EventArgs e)
        {
            this.Paint += Form1_Paint1;
            this.Invalidate();
            this.Update();
        }

        private void Form1_Paint1(object sender, PaintEventArgs e)
        {
            g.Clear(Color.White);
            new Second().ByDrawLine(g, 300, 300, 500, 500);
        }
    }
}
