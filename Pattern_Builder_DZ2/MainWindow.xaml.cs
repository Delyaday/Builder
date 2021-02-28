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

namespace Pattern_Builder_DZ2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Director director = new Director();
            HouseBuilder builder = new RichHouse();
            House richHouse = director.build(builder);
            MessageBox.Show(richHouse.ToString());
           

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Director director = new Director();
            HouseBuilder builder3 = new PoorHouse();
            House poorHouse = director.build(builder3);
            MessageBox.Show(poorHouse.ToString());
        }
    }
}
