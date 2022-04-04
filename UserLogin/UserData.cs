using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace UserLogin
{
    public static class UserData
    {
        public static List<User> TestUsers
        {
            get {
                ResetTestUserData();
                return _testUsers;
            }
            set { }
        }
        static private List<User> _testUsers = new List<User>();
        private static void ResetTestUserData()
        {
            _testUsers.Add(new User("Ivancho", "1234567", "12345", DateTime.Today, DateTime.MaxValue, UserRoles.STUDENT));
            _testUsers.Add(new User("Georgi", "123456", "12345", DateTime.Today, DateTime.MaxValue, UserRoles.STUDENT));
            _testUsers.Add(new User("Nikolay", "12345", "12345", DateTime.Today, DateTime.MaxValue, UserRoles.ADMIN));

        }

        public static User isUserPassCorrect(String username, String password)
        {
            List<User> foundUser =
                (
                 from user
                 in _testUsers
                 where user.Name == username && user.Password == password
                 select user
                 ).ToList();

            if(foundUser.Count() > 0)
            {
                return foundUser.First();
            }
            else
            {
                return null;
            }
        }

        public static void SetUserActiveTo(String name, DateTime expireDate)
        {
            foreach(User user in _testUsers)
            {
                if(user.Name == name)
                {
                    user.ExpireDate = expireDate;
                    Logger.LogActivity("Expire date changed for " + name);
                }
            }
        }
        public static void AssignUserRole(String name, UserRoles newRole)
        {
            foreach (User user in _testUsers)
            {
                if (user.Name == name)
                {
                    user.Role = newRole;
                    Logger.LogActivity("New role assigned for " + name);
                }
            }
        }
        public static void PrintUsers()
        {
            foreach(User user in _testUsers)
            {
                Console.WriteLine(user.Name + " " + user.FakNum + " " + user.Role + " " + user.Created + " " + user.ExpireDate);
            }
        }
    }
}
