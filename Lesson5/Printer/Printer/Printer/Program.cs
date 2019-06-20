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
            var printer = new Printer("value");
            printer.Print(printer.PrintStream);

            var colourprinter = new ColourPrinter("ColorValue");
            colourprinter.Print(colourprinter.PrintStream);
            colourprinter.Print(colourprinter.PrintStream, ConsoleColor.Green);

            var photoprinter = new PhotoPrinter("PhotoValue");
            photoprinter.Print(photoprinter.PrintStream);
            var photo = new Photo();
            photo.makePhoto();
            photoprinter.Print(photo.picture, ConsoleColor.DarkYellow);

            Console.ReadLine();


        }
        public class Printer

        {
            public string PrintStream;
            public Printer(string value)
            {
                PrintStream = value;
            }
            public virtual void Print(string value)
            {
                Console.WriteLine(value);
            }
        }
        public class ColourPrinter : Printer
            {
                      
            public ColourPrinter(string value)
                : base(value)
            {
            }

            public override void Print(string value)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                base.Print(value);
            }
            public void Print(string text, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{text}");
            }
        }

        class PhotoPrinter : Printer
            {
            public PhotoPrinter(string value)
                : base(value)
            {
            }
            
            public override void Print(string value)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                base.Print(value);
            }

            public void Print(object photo, ConsoleColor color)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{photo}");
            }
        }
        class Photo
        {
            public string picture { get; set; }
            public string makePhoto()
                {
                for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine();
                        for (int j = 0; j<5; j++)
                        {
                            Console.Write("* ");
                        }
                    
                    }
                return picture;
            } 
        }
        
    }
}
