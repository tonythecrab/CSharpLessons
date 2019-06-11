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

            try
            {
                Console.WriteLine("Select min border");
                int minValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select max border");
                int maxValue = Convert.ToInt32(Console.ReadLine());
            
            
            do
            {
                int random = RandomNumber(minValue, maxValue);
                int attempt = 3;
                Console.WriteLine("New round.");
                do
                {
                    Console.WriteLine("Enter a number");
                    int value = Convert.ToInt32(Console.ReadLine());
                    if (value == random)
                    {
                        Console.WriteLine("Correct.");
                        break;
                    }
                    else
                    {
                        attempt--;
                        Console.WriteLine($"Wrong number. Attempts left: {attempt}");
                    }
                } while (attempt > 0);
                
            } while (true == true);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} wrong input", e);
            }

            }
    }
}
