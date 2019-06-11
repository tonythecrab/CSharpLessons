using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_5
{
    class Program
    {
        static void Main(string[] args)
        {
           // Generate a random number between two numbers
            int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
            
            Console.WriteLine("Select min border");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select max border");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            do
            { RandomNumber(minValue, maxValue); }

            
        }
    }
}
