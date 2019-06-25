using System;


namespace Array2
{
    class Program
    {
        static void Main(string[] args)
        {
            Arr NewArray = new Arr(4, 5, 6, 7);
            //Arr NewArray = new Arr(new int[] { 4, 5, 6, 7 });
            
            //PrintArray(NewArray);  // почему возвращает Array2.Arr ? 
            PrintArray2(NewArray);
            var answer = NewArray.Contains(5);
            Console.WriteLine($"{answer}");
            Console.WriteLine(NewArray.Contains(5)); //Запомнить вызов метода внутри др метода 
            NewArray.GetByIndex(2,NewArray);
            
            Console.WriteLine($"{NewArray.NumberbyIndex}");
            Console.WriteLine("--------");
            NewArray.Add(10);
            PrintArray2(NewArray);
            Console.ReadLine();
            
        }


        public static void PrintArray2(Arr Arr)
        {
            foreach (var i in Arr.Array)
            {
                    Console.WriteLine(i);
            }
        }

        public static void PrintArray(Arr[] Arr) //int[] int  Принимает массив и помещает в массив массивов [Array2.NewArray;]
        {
            foreach (var i in Arr)
            {
                foreach(var j in i.Array)
                {
                    Console.WriteLine(j);

                }
            }
        }
    }

    public class Arr
    {
        public int[] Array { get; set; }
        public int NumberbyIndex { get; set; }

        public int[] _newArray { get; set; }
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

        public void GetByIndex(int index, Arr arr)
        {
            
            Console.WriteLine(arr.Array[index]);
                    
          
        }

        public int[] Add(int value)
        {
            int[] tempArray = new int[Array.Length + 1];
            for (int i = 0; i < Array.Length; i++)
            {
                tempArray[i] = Array[i];
            }
            tempArray[Array.Length] = value;
            Array = tempArray;

            return tempArray;
        }
    }
}
