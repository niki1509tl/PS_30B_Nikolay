using System;
using System.Text;
using System.Collections.Generic;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> listUsers = UserData.TestUsers;
            LoginValidation loginValidation = CreateLoginValidation();
            User user = new User("Ivan", "testt123", "121219052", DateTime.Today, DateTime.MaxValue, UserRoles.STUDENT);

            bool authenticate = loginValidation.ValidateUserInput(user);
            if (authenticate)
            {
                switch (LoginValidation.CurrentUserRole)
                {
                    case UserRoles.STUDENT:
                        Console.WriteLine("Student");
                        break;
                    case UserRoles.ADMIN:
                        Console.WriteLine("Admin");
                        handleAdminInterface();
                        break;
                    default:
                        Console.WriteLine("Default - role not found");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Wrong Login Credentials");
            }
        }

        static void handleAdminInterface()
        {
            int choice = 3;
            while (choice != 0)
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Change role for user");
                Console.WriteLine("2: Change expire date for user");
                Console.WriteLine("3: List of users");
                Console.WriteLine("4: List of activities");
                Console.WriteLine("5: List of current activities");

                choice = Int32.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    return;
                }
                else if (choice == 1)
                {
                    Console.WriteLine("Type username:");
                    String username = Console.ReadLine();
                    Console.WriteLine("Type role as int:");
                    UserRoles role = (UserRoles)Int32.Parse(Console.ReadLine());
                    UserData.AssignUserRole(username, role);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Type username:");
                    String username = Console.ReadLine();
                    Console.WriteLine("Type role as int:");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    UserData.SetUserActiveTo(username, date);
                }else if(choice == 3)
                {
                    UserData.PrintUsers();
                }
                else if (choice == 4)
                {
                    StringBuilder sb = new StringBuilder();
                    IEnumerable<string> activities =
                    Logger.GetActivities();
                    foreach (string line in activities)
                    {
                        sb.Append(line + '\n');
                    }
                    Console.WriteLine(sb);
                }
                else if(choice == 5)
                {
                    Console.WriteLine("Filter if you want:");
                    String filter = Console.ReadLine();
                    StringBuilder sb = new StringBuilder();
                    IEnumerable<string> currentActs =
                    Logger.GetCurrentSessionActivities(filter);
                    foreach (string line in currentActs)
                    {
                        sb.Append(line);
                    }
                    Console.WriteLine(sb);
                }
            }

        }

        static LoginValidation CreateLoginValidation()
        {
            String username;
            String password;
            Console.WriteLine("Enter your username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            password = Console.ReadLine();
            return new LoginValidation(username, password, ActionOnErr);
        }

        public static void ActionOnErr(String errorMsg)
        {
            Console.WriteLine("!!!" + errorMsg + "!!!");
        }
    
       
    }
}
