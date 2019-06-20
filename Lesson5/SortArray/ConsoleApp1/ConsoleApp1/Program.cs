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

            Random randomizer = new Random();
            
            int[] nums = new int[10];
            //foreach (int i in nums)
            //{
            //    nums[i] = randomizer.Next(100); // почему всегда переписывает 1 значение массива?
            //}
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = randomizer.Next(100);
            }

            Array.Sort(nums);
            foreach (int n in nums)
                Console.WriteLine(n);

            Console.ReadLine();
        }
    }
}
