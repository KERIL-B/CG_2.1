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
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Main go;
        public MainWindow()
        {
            InitializeComponent();
            backgroundCnvs.Background = new ImageBrush(new BitmapImage(new Uri("IMG\\city.png", UriKind.Relative)));
            go = new Main(skyCnvs);
        }

        private void backgroundCnvs_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            go.ChangeSpeed(e.Delta>0);
            
        }
    }
}
