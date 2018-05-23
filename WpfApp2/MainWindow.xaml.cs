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

        private void SliderEvent(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rect.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(red.Value), Convert.ToByte(green.Value), Convert.ToByte(blue.Value)));

            var redHex = addZero(Convert.ToInt32(red.Value).ToString("X"));
            var greenHex = addZero(Convert.ToInt32(green.Value).ToString("X"));
            var blueHex = addZero(Convert.ToInt32(blue.Value).ToString("X"));


            toplabel.Content = $"#{redHex}{greenHex}{blueHex}";
            redLabel.Content = $"Red: {redHex}";
            greenLabel.Content = $"Green: {greenHex}";
            blueLabel.Content = $"Blue: {blueHex}";
        }

        private string addZero(string s)
        {
            if (s.Length == 1)
            {
                return "0" + s;
            }
            else
            {
                return s;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var rand = new Random();
            var redRand = rand.Next(255);
            var greenRand = rand.Next(255);
            var blueRand = rand.Next(255);

            rect.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(redRand), Convert.ToByte(greenRand), Convert.ToByte(blueRand)));

            red.Value = redRand;
            green.Value = greenRand;
            blue.Value = blueRand;

            var redHex = addZero(Convert.ToInt32(redRand).ToString("X"));
            var greenHex = addZero(Convert.ToInt32(greenRand).ToString("X"));
            var blueHex = addZero(Convert.ToInt32(blueRand).ToString("X"));

            toplabel.Content = $"#{redHex}{greenHex}{blueHex}";
            redLabel.Content = $"Red: {redHex}";
            greenLabel.Content = $"Green: {greenHex}";
            blueLabel.Content = $"Blue: {blueHex}";

        }
    }
}
