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
            
            InitializeComponent();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            this.Paint += ChartForm_Paint;
            this.Invalidate();
            this.Update();
            Function function = new Function(functionInputTextBox.Text);
            func = function.func;
        }

        private void ChartForm_Paint(object sender, PaintEventArgs e)
        {
            g = this.CreateGraphics();
            ChartPainter chartPainter = new ChartPainter();
            chartPainter.PrintCoordinateSystem(g);
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(func(double.Parse(textBox1.Text)).ToString());
        }
    }
}
