using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.CarInfo();          
            TuningAtelier.TuneCar();
            
        }

    }

    public class Car
    {
        public static string Model = "MDX";
        public static string Color = "Green";
        public static int Year = 2010;
        public static void CarInfo()
        {
            Console.WriteLine($"You car {Model}, manufactured in {Year}, has {Color} color");
        }
    }

    static class TuningAtelier

    {
        public static void TuneCar()
        {
            Car car = new Car();
            Car.Color = "red";
            Console.WriteLine($"Tunned {Car.Model} manufactured in {Car.Year} year. Changed color to {Car.Color}");
            Console.ReadLine();
        }


    }

}
