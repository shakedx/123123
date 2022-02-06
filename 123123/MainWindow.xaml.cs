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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {

            Body body = new Body(double.Parse(texta.Text), double.Parse(textb.Text), double.Parse(textc.Text),
                double.Parse(textd.Text));
            Result.Text = body.Print();
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            Body body = new Body(double.Parse(texta.Text), double.Parse(textb.Text), double.Parse(textc.Text),
                double.Parse(textd.Text));
            Result.Text = body.Print();
        }


    }
}

