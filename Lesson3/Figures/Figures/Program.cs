using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        

        //var figure3 = "romb"; The contextual keyword 'var' may only appear within a local variable declaration or in script code 
        static void Main(string[] args)
        {
            Console.WriteLine("Using this app you can visualize geometric figures");
            string figure1 = "1";
            string figure2 = "square";
            string figure3 = "romb";


            Console.WriteLine($"Please chose one figure: ");
            showVarints(figure1);
            showVarints(figure2);
            showVarints(figure3);

            string figure = Console.ReadLine();



            printFigure(figure);
            Console.ReadLine();
        }

        public static void showVarints(string variant)
        {
            Console.WriteLine($"Print {variant}, to show {variant}");
        }

        public static void printFigure(string value = "1")
        {
            if (value == "1")
            {
                for (int i = 1; i == 5; i++)
                {
                    Console.WriteLine("*");
                }

            }

        }
    }
}
