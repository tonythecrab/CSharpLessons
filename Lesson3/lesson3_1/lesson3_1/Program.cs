using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start");

            Console.ReadLine();
            Console.WriteLine("square");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("");
                for (int k = 1; k < 6; k++)
                {
                    Console.Write("*");
                }
            }

            Console.ReadLine();
        }
    }
}
