using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter engine type");
            string engineValue = Console.ReadLine();
            Console.WriteLine("Enter engine type 2");
            string engineValue2 = Console.ReadLine();
            Console.WriteLine("Enter car color");
            string colorValue = Console.ReadLine();
            Console.WriteLine("Enter transmission type");
            string transmissionValue = Console.ReadLine();

            var engine1 = new Engine(engineValue);
            var engine2 = new Engine(engineValue2);
            var transmission1 = new Transmission(transmissionValue);
            var color1 = new Color(colorValue);

            var car = CarConstruct.Construct(engine1, color1, transmission1);
            
            car.getCarInfo();

            CarConstruct.Reconstruct(car, engine2);
                car.getCarInfo();
            //var upgrade = new CarConstruct(car1);
            Console.ReadKey();
        }

    }

}