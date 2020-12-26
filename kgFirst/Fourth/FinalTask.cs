using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask
{
    public partial class FinalTaskForm : Form
    {
        public static BackgroundWorker backgroundWorker;
        SortWithPaint SortWithPaint = new SortWithPaint();
        public static ArrayElement[] array;
        public static ArrayElement selectedElement;
        public FinalTaskForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            bool first = false;
            if (array != null)
            {
                Graphics graphics = e.Graphics;
                for (int i = 0; i < array.Length; i++)
                {
      
                        var point = array[i].Location;
                        var rect = new Rectangle(point.X, point.Y, 50, 50);
                    if(selectedElement!=null)
                    {
                        if(selectedElement.Location.X==point.X)
                        {
                            var point1 = selectedElement.Location;
                            var rect1 = new Rectangle(point1.X, point1.Y, 50, 50);
                            graphics.FillEllipse(Brushes.Gray, rect1);
                            TextRenderer.DrawText(graphics, selectedElement.Value.ToString(), new Font("Arial", 16), rect1, selectedElement.Color,
                                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                            var str = Environment.CurrentDirectory;
                            Bitmap bitmap = new Bitmap(str + "/long-arrow-up.png");
                            var point2 = new Point(point1.X - 60, point1.Y-50);
                            graphics.DrawImage(bitmap,point2);
                        }
                    }
                    if(!first && array[i].Color==Color.Green)
                    {
                        var str = Environment.CurrentDirectory;
                        Bitmap bitmap = new Bitmap(str + "/long-arrow-right.png");
                        var point2 = new Point(point.X + 20, point.Y-10);
                        graphics.DrawImage(bitmap, point2);
                        first = !first;
                    }
                        graphics.FillEllipse(Brushes.Gray, rect);
                        TextRenderer.DrawText(graphics, array[i].Value.ToString(), new Font("Arial", 16), rect, array[i].Color,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Update();
            try
            {
                int n = int.Parse(arrayLengthTextBox.Text);
                array = SortWithPaint.GenerateArray(n);
            }
            catch (Exception ex)
            {
                array = SortWithPaint.GenerateArray(5);
            }

            panel1.Invalidate();
            
        }

        private  void RunBtn_Click(object sender, EventArgs e)
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

            backgroundWorker.RunWorkerAsync();

        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            panel1.Invalidate();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            SortWithPaint.InsertSort(array, panel1, animationSpeedTrackar.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PropertyInfo db = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic |
               BindingFlags.Instance);
            db.SetValue(panel1, true);
        }
    }
}
