using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Tony", 22 );

            void CopyUser(User user)
            {

                user = new User(user.name, user.age);
                Console.WriteLine(user.name);
                Console.ReadLine();// 
            }

            CopyUser(user1);
           
        }

        class User

        {
           public string name ;
           public int age;

            public User(string fname, int Age) { name = fname; age = Age; }


           
        }


        //class Copy
        //{
        //    public string copyvalue1;
        //    public int copyvalue2;

        //    public Copy(User user) { User userCopy = new User(User) };
        //}



        
    }
}
