using System;


namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arr NewArray = new Arr(1, 2, 3, 4);
            PrintArray(NewArray);  // почему возвращает Array2.Arr ?
            var answer = NewArray.Contains(5);
            Console.WriteLine($"{answer}");
            Console.ReadLine();
        }
        



        public static void PrintArray(params Arr[] Arr)
        {
            foreach (var i in Arr)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Arr
    {
        public int[] Array { get; set; }
        public Arr(params int[] ArrayIn)
        {
            Array = ArrayIn;
        }
        public bool Contains(int value)
        {
            foreach (int i in Array)
            {
                if (i == value) { return true; }
            }
            return false;
        }
        

    }
}
