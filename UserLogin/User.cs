using System;
using System.Collections.Generic;
using System.Text;

namespace UserLogin
{
    public class User
    {
        public String Name { get; set; }
        public String Password { get; set; }
        public String FakNum { get; set; }
        public DateTime Created { get; set; }
        public DateTime ExpireDate { get; set; }
        public UserRoles Role { get; set; }

        public User(String name, String password, String fakNum, DateTime createdDate, DateTime expireDate,UserRoles role)
        {
            this.Name = name;
            this.Password = password;
            this.FakNum = fakNum;
            this.Created = createdDate;
            this.ExpireDate = expireDate;
            this.Role = role;
        }
    }
}
