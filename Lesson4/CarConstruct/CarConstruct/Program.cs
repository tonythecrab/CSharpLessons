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
            var car1 = new Car(engine1, color1, transmission1);
            car1.getCarInfo();
            var upgrade = new CarConstruct(car1);
            Console.ReadKey();
        }

    }

}
    
    class Engine
    {
        public string engineType { get; set; }

        public Engine(string EngineType)
        {
            engineType = EngineType;
        }
    }

    class Color
    {
        public string colorValue { get; set; }

        public Color(string ColorValue)
        {
            colorValue = ColorValue;
        }
    }

    class Transmission
    {
        public string TransmissionType { get; set; }

        public Transmission(string transmissionType)
        {
            transmissionType = TransmissionType;
        }
    }

    class CarConstruct
    {


        Engine engine;
       
        public CarConstruct(Car value, Engine eng)
        {
        
        }
    }

    class Car
    {
        Engine engine;
        Color color;
        Transmission transmission;
        public Car(Engine eng, Color col, Transmission trans )
        {
            engine = eng; color = col; transmission = trans;
        }
        public void getCarInfo()
        {
            Console.WriteLine($"Car with {engine}, {transmission} type and {color} color");
        }
    }


