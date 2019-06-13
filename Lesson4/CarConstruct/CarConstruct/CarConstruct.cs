using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConstruction
{
    class CarConstruct
    {

        public static Car Construct(Engine engine, Color color, Transmission transmission)
        {

            var car1 = new Car(engine, color, transmission);
            return car1;
        }

        public static void Reconstruct(Car car, Engine engine)
        {
            car.engine = engine;
        }
    }
}
