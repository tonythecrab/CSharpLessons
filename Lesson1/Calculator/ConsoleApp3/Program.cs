using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a =0;
            decimal b =0;
            string  c="a";
            decimal d=0;
            Console.WriteLine("Please enter the 1st number");
            a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please enter the 2nd number");
            b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please choose the operation type: +,-,/,*");
            c = Console.ReadLine();
            if (c == "+")
            {
                Console.WriteLine("Answer is: " + (d = a + b));
            }
            else if (c == "-")
            {
                Console.WriteLine("Answer is: " + (d = a - b));
            }
            else if (c == "/")
            {
                Console.WriteLine("Answer is: " + (d = a / b));
            }
            else if (c == "*")
            {
                Console.WriteLine("Answer is: " + (d = a * b));
            }
            else Console.WriteLine("You entered a wrong opeation type, no more chance, bye...");
            Console.ReadLine();


        }
    }
}
