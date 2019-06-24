using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string pass;
            string email;
            do
            {
                name = Console.ReadLine();
                pass = Console.ReadLine();
                email = Console.ReadLine();
                if (name != "exit" && pass != "exit")
                {
                    var user = new User(name, pass, email);

                    Users[] users = new Users[10];
                    for (int i = 0; i < i+1; i++)
                    {
                        users[i] = user;
                    }
                       
                    Console.WriteLine($"Welcome to the Matrix {user.Name}");
                }


            } while (name != "exit" && pass != "exit");
        }

        public class Users { }

        public interface IUser
        {
            string Name { get; set; }
            string Password { get; set; }
            string Email { get; set; }

            //string GetFullInfo();
            
        }
        interface IValidator
        {
            void ValidateUser();
        }

        public class User : Users, IUser
        {
            public User(string name, string password, string email)
            {
                Name = name;
                Password = password;
                Email = email;
            }
            public string Name { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }

        }
    }
}
