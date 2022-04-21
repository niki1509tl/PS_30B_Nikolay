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
using StudentInfoSystem.View;
using StudentInfoSystem.ViewModel;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = new StudentPreseneter();
            InitializeComponent();
            Title = "Student information system.";
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            new LoginDialog().ShowDialog();
        }

        private void disableFields_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox tb in personalInfoGrid.Children.OfType<TextBox>())
            {
                tb.IsEnabled = false;
            }
            foreach (TextBox tb in studentInfoGrid.Children.OfType<TextBox>())
            {
                tb.IsEnabled = false;
            }
        }

        private void enableFIelds_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox tb in personalInfoGrid.Children.OfType<TextBox>())
            {
                tb.IsEnabled = true;
            }
            foreach (TextBox tb in studentInfoGrid.Children.OfType<TextBox>())
            {
                tb.IsEnabled = true;
            }
        }
    }
}
