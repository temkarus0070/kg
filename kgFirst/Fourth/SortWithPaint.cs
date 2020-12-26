using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTask
{

    public class SortWithPaint
    {
        public int time = 100;
        private static Point[] points;
        public Random random = new Random(6);
        public int width = Screen.PrimaryScreen.WorkingArea.Width;
        public int height = Screen.PrimaryScreen.WorkingArea.Height;
        public void InsertSort(ArrayElement[] array, Panel panel,int speed)
        {
            for (int i = 1; i < array.Length; i++)
            {
                panel.Update();
                var element = array[i];
   
                DownAnimation(array, i, panel);
              
                Thread.Sleep(speed*1000);
                int j = i - 1;
                while (j >= 0 && array[j].Value > element.Value)
                {
                    SelectElement(array, j, panel);
                    SelectElement(array, j+1, panel);
                    Thread.Sleep(speed * 1000);
                    var e = new ArrayElement(array[j].Value, new  Point(array[j].Location.X,array[j].Location.Y));
                    e.Color = Color.White;
                    array[j + 1] = array[j];
                    array[j + 1].Location = points[j + 1];
                    array[j] = e;
                    array[j + 1].Color = Color.White;
                  
                    array[j].Color = Color.White;
                    j--;
                    Thread.Sleep(speed * 1000);
                    Point pointForElement = new Point(points[j+1].X, points[j+1].Y+60);
                    
                    FinalTaskForm.selectedElement = new ArrayElement(element.Value, pointForElement);
                    FinalTaskForm.selectedElement.Color = Color.White;
                    panel.Invalidate();
                    
              

                }
                array[j + 1] = element;
                array[j + 1].Location = points[j + 1];

                FinalTaskForm.selectedElement = null;
              

            }
            panel.Invalidate();


        }

        public void SelectElement(ArrayElement[] array, int i, Panel panel)
        {
            array[i].Color = Color.Green;
            panel.Invalidate();
        }



        public void DownAnimation(ArrayElement[] array, int index, Panel panel)
        {




            var location = array[index].Location;
            location.Y += 60;
            array[index] = new ArrayElement(array[index].Value, location);
            FinalTaskForm.selectedElement = new ArrayElement(array[index].Value, location);
            FinalTaskForm.selectedElement.Color = Color.Green;
          
            panel.Invalidate();
      

        }

        



        public ArrayElement[] GenerateArray(int n)
        {
            int x1 = 0;
            int y1 = 25;
            ArrayElement[] array = new ArrayElement[n];
            points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                Point point = new Point(x1, y1);
                array[i] = new ArrayElement(random.Next(1000), point);
                points[i] = point;
                x1 += 80;


            }
            return array;
        }


    }

    public class ArrayElement
    {
        public int Value { get; set; }
        public Point Location { get; set; }
        public Color Color { get; set; }

        public ArrayElement(int value, Point point)
        {
            this.Value = value;
            this.Location = point;
            Color = Color.White;
        }
    }
}
