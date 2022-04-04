using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    public class LoginValidation
    {   
        public static String Username;
        public static String Password;
        public static String ErrorMessage;
        public static UserRoles CurrentUserRole { get; private set; }
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError _errorfunc;

        public LoginValidation(String username, String password, ActionOnError _errorfunc)
        {
            Username = username;
            Password = password;
            this._errorfunc = _errorfunc;
        }
        public bool ValidateUserInput(User user)
        {
            if (!isValidUsername() || !isValidPassword())
            {
                CurrentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
            User validatedUser = UserData.isUserPassCorrect(Username,Password);
            if(validatedUser != null)
            {
                user = validatedUser;
                CurrentUserRole = validatedUser.Role;
                Logger.LogActivity("Successfull Login");
                return true;
            }
            else
            {
                ErrorMessage = "Username or Password incorrect";
                CurrentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
        }

        private Boolean isValidUsername()
        {
            if (Username.Equals(String.Empty)){
                ErrorMessage = "No username";
                _errorfunc(ErrorMessage);
                return false;
            }
            if(Username.Length < 5)
            {
               ErrorMessage = "Username is less than 5 symbols";
                _errorfunc(ErrorMessage);
                return false;
            }
            return true;
        }
        private Boolean isValidPassword()
        {
            if (Password.Equals(String.Empty))
            {
                ErrorMessage = "No password";
                _errorfunc(ErrorMessage);
                return false;
            }
            if (Password.Length < 5)
            {
                ErrorMessage = "Password is less than 5 symbols";
                _errorfunc(ErrorMessage);
                return false;
            }
            return true;
        }
    }
}
