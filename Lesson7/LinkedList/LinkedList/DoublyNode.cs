using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class DoublyNode<T>
    {
        public LinkedList<T> NewList = new LinkedList<T>();

        public void Add(T data)
        {
            NewList.AddLast(data);
        }
        public bool Remove(T data)
        {
            return NewList.Remove(data);
        }
        public int counter(LinkedList<T> list)
        {
            int _counter = 0;
            foreach (var i in list)

            {
                _counter++;
            }
            return _counter;

        }
        public void ToArray(LinkedList<T> list)
        {
            var arrayLength = counter(list);
            T[] array = new T[arrayLength];

            int j = 0;
            foreach (var i in list)
            {

                array[j] = i;
                j++;

            }

        }

    }
}
