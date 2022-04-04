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

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Student information system.";
        }

        private void clearForm_Click(object sender, RoutedEventArgs e)
        {
            foreach(TextBox tb in this.Grid.Children.OfType<TextBox>())
            {
                tb.Text = "";
            }
        }

        private void fillSampleData_Click(object sender, RoutedEventArgs e)
        {
            Student student = StudentData.TestStudents.First();
            this.nameField.Text = student.Name;
            this.middleNameField.Text = student.MiddleName;
            this.lastNameFIeld.Text = student.LastName;
            this.facultyField.Text = student.Faculty;
            this.specialityField.Text = student.Speciality;
            this.okcField.Text = student.Degree;
            this.statusField.Text = student.Status;
            this.facNumField.Text = student.FacNum;
            this.courseField.Text = student.Course.ToString();
            this.flowFIeld.Text = student.Flow.ToString();
            this.groupField.Text = student.Group.ToString();
        }

        private void disableFields_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox tb in this.Grid.Children.OfType<TextBox>())
            {
                tb.IsEnabled = false;
            }
        }

        private void enableFIelds_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox tb in this.Grid.Children.OfType<TextBox>())
            {
                tb.IsEnabled = true;
            }
        }
    }
}
