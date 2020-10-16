using kgFirst.Second;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgFirst.Forms
{
    public partial class ChartForm : Form
    {
        Graphics g;
        Function.functionFromX func;
        public ChartForm()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
         
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        

        private void RunBtn_Click(object sender, EventArgs e)
        {
            
            g = this.CreateGraphics();
            Function function = new Function(functionInputTextBox.Text);
            func = function.func;
          paintChart(g);
            this.Resize+=Paint_Form;
        }

         private void Paint_Form(object sender, EventArgs e)
        {
             g = this.CreateGraphics();
         paintChart(g);
        }

       

        private void paintChart(Graphics g)
            {
            g.Clear(Color.White);  
            ChartPainter chartPainter = new ChartPainter();
             chartPainter.PrintCoordinateSystem(g);
            chartPainter.PaintChart(func, g);
            g.Dispose();
}

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(func(float.Parse(textBox1.Text)).ToString());
        }
    }
}
