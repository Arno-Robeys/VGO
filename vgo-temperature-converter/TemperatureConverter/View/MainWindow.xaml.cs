using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
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
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ConverterViewModel();
        }

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(this, $"{textBox2.Text}°F is {(Double.Parse(textBox2.Text) - 32) / 1.8}°C", "Convert Fahrenheit naar Celcius", MessageBoxButton.OK);
            textBox.Text = $"{(Double.Parse(textBox2.Text) - 32) / 1.8}";
        }

        private void ConvertToFahrenheit(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(this, $"{textBox.Text}°C is {(Double.Parse(textBox.Text) * 1.8) + 32}°F", "Convert Celcius naar Fahrenheit", MessageBoxButton.OK);
            textBox2.Text = $"{(Double.Parse(textBox.Text) * 1.8) + 32}";
        }
    }
}
