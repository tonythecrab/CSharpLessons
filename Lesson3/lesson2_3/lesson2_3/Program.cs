using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start");

            Console.ReadLine();
            Console.WriteLine("romb");
            for (int i = 5; i > 0; i--)
            {
                Console.Write("");
                for (int k = 1; k < i + 1; k++)
                {
                    Console.Write("*");
                }
            }

            Console.ReadLine();
        }
    }
}
