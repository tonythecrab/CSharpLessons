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
            Console.WriteLine("byte Min: " + byte.MinValue + " Max: " + byte.MaxValue + " Default: 0");
            Console.WriteLine("sbyte Min: " + sbyte.MinValue + " Max: " + sbyte.MaxValue + " Default: 0");
            Console.WriteLine("short Min: " + short.MinValue + " Max: " + short.MaxValue + " Default: 0");
            Console.WriteLine("ushort Min: " + ushort.MinValue + " Max: " + ushort.MaxValue + " Default: 0");
            Console.WriteLine("int Min: " + int.MinValue + " Max: " + int.MaxValue + " Default: 0");
            Console.WriteLine("uint Min: " + uint.MinValue + " Max: " + uint.MaxValue + " Default: 0");
            Console.WriteLine("long Min: " + long.MinValue + " Max: " + long.MaxValue + " Default: 0L");
            Console.WriteLine("ulong Min: " + ulong.MinValue + " Max: " + ulong.MaxValue + " Default: 0");
            Console.WriteLine("float Min: " + float.MinValue + " Max: " + float.MaxValue + " Default: 0,0F");
            Console.WriteLine("double Min: " + double.MinValue + " Max: " + double.MaxValue + " Default: 0,0D");
            Console.WriteLine("decimal Min: " + decimal.MinValue + " Max: " + decimal.MaxValue + " Default: 0M");
            Console.ReadKey();
        }
    }
}
