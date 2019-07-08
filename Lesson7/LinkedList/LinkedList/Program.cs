using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string choise = null;

            var listClass = new DoublyNode<string>();
            while (true)
            {
                Console.WriteLine("Pleasse chose one option " +
                    "\n press 1 to Add item " +
                    "\n press 2 to item " +
                    "\n press 3 to count all existing items " +
                    "\n press 4 to create an array of existing items");
                choise = Console.ReadLine();

                switch (choise)
                {
                    case "1":
                        Console.WriteLine("Please enter a value");
                        var item = Console.ReadLine();
                        listClass.Add(item);
                        break;

                    case "2":
                        Console.WriteLine("Please enter a value");
                        item = Console.ReadLine();
                        listClass.Remove(item);
                        break;
                    case "3":

                        var counter = listClass.counter(listClass.NewList);
                        Console.WriteLine(counter);
                        break;

                    case "4":

                        listClass.ToArray(listClass.NewList);
                        break;
                }
            }
        }
    }
}