using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Bob");
            Human human2 = new Human("Bob");
            Human.compare(human1, human2);
            Console.ReadLine();
        }

    }

    class Human
    {
        public int BirthDate;
        public string FirstName;
        public string LastName;
        public int Age { get; }

        public Human() { FirstName = "undefined"; }
        public Human(string fname) { FirstName = fname; BirthDate = 1900; }

        public Human(string fname, string lname, int age) { FirstName = fname; LastName = lname; }

        public void getInfo()
        {
            Console.WriteLine($"Human {LastName + FirstName} burn in {BirthDate}, now {Age} years old");
        }

        public static void compare(Human value1, Human value2)
        {
            if (value1 == value2)
            {
            Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");//всегда False? 
            };
        }
             
        

    }
}
