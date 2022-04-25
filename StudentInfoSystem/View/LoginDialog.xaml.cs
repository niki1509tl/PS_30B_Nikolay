using System;
using System.Windows;
using UserLogin;
namespace StudentInfoSystem.View
{
    /// <summary>
    /// Interaction logic for LoginDialog.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {
        private readonly LoginAction _loginAction;

        public delegate void LoginAction(Student student);
        public LoginDialog(LoginAction loginAction)
        {
            _loginAction = loginAction;
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            var login = new LoginValidation(Username.Text, Password.Password, msg =>
            {
                ErrorMessage.Content = msg;
            });
            try
            {
                User user = login.FindUser(Username.Text, Password.Password);
                _loginAction(new StudentValidation().GetStudentDataByUser(user));
                Close();
            }
            catch (Exception err)
            {
                ErrorMessage.Content = err.Message;
            }
            
        }

    }
}
