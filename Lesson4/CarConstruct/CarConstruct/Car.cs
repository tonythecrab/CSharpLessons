using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstruction
{
    public class Car
    {
        public Engine engine { get; set; } 
        Color color;
        Transmission transmission;
        public Car(Engine eng, Color col, Transmission trans)
        {
            engine = eng; color = col; transmission = trans;
        }
        public void getCarInfo()
        {
            Console.WriteLine($"Car with {engine.engineType}, {transmission} type and {color} color");
        }
    }
}
