using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CG_2._1
{
    class Main
    {
        double phase { get; set; }
        double x { get; set; }
        Canvas canvas;
        Ellipse sky;
        System.Timers.Timer timer;


        public Main(Canvas canvas)
        {
            this.canvas = canvas;
            this.sky = new Ellipse();
            sky.Height = 1000;
            sky.Width = 1000;
            sky.Fill = new ImageBrush(new BitmapImage(new Uri("IMG\\sky.png", UriKind.Relative)));
            sky.Margin = new Thickness(-250, -200, 0, 0);
            canvas.Children.Add(sky);
            x = 1;

            timer = new System.Timers.Timer(41);
            timer.Elapsed += timer_Elapsed;
            timer.Start();
        }

        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            phase += x;
            try
            {
                sky.Dispatcher.Invoke(() =>
                    {
                        sky.RenderTransform = new RotateTransform(phase, sky.Width / 2, sky.Height / 2);

                    });
            }
            catch (Exception) { }
        }

        public void ChangeSpeed(bool faster)
        {
            if (faster)
                x += 0.05;
            else
                x -= 0.05;
        }
    }
}
