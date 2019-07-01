using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class User : IUser
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime LastLogin { get; set; }
        

        public void GetFullInfo()

        {

        }
        

        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
            LastLogin = (DateTime.Now);
        }

        public void GetFullInfo(User user)

        {
            Console.WriteLine($"User {user.Name} exists. Last login {user.LastLogin}");
        }
    }
}
