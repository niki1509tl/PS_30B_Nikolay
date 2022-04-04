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

namespace WPFhello
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

        private void ValidateValues(object sender, RoutedEventArgs e)
        {
            ErrorMessage.Content = "";
            string value = Value.Text;
            try
            {
                int result = Int32.Parse(value);
                Rectangle.RenderTransform = new RotateTransform(result, 60, 20);
                InsertValue(result);
            }catch(FormatException)
            {
                ErrorMessage.Content = "Invalid input";
                ErrorMessage.Foreground = Brushes.Red;
            }
        }

        private void InsertValue(int value)
        {
            TextBlock txt2 = new TextBlock();
            txt2.Text = value.ToString();
            Thickness thickness = new Thickness();
            thickness.Top = value;
            txt2.Margin = thickness;
            History.Children.Add(txt2);
        }
    }
}