using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer {value = "test" };
            
        }
        public abstract class Printer
             
        {
            public string value;
            public virtual void Print(string value)
            {
                Console.WriteLine(value);
            }

        public class ColourPrinter : Printer
            {
                public override void Print(string value)
                {
                    base.Print(value);
                }
            }

        class PhotoPrinter : Printer
            {
                public override void Print(string value)
                {
                    base.Print(value);
                }
            }
        }
    }
}
