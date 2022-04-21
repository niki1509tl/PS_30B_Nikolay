using System;
using System.Collections.Generic;
using System.Text;
using StudentInfoSystem.Model;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModel
{
    class UserPresenter : ObservableObject
    {
        private User _user;

        public User User
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                RaisePropertyChangedEvent("User");
            }
        }

        public ICommand LoginCommand
        {
            get { return new DelegateCommand(LoginValidation); }
        }
        public void LoginValidation()
        {

        }
    }
}
