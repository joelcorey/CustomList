using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
     public class CustomList<T> : IEnumerable<T>
    {
        private T[] currentArray;
        private T[] temporaryArray;
        private int capacity;
        private int count;

        public CustomList()
        {
            capacity = 5;

            currentArray = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                return currentArray[index];
            }
            set
            {
                currentArray[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return currentArray.Take(count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T element)
        {
            if (count >= capacity)
            {
                Console.WriteLine("Red alert, capacity is 0");
                // make temporary array to copy data
                capacity *= 2;
                temporaryArray = new T[capacity];
                int temporaryIndex = 0;
                // copy currentArray to temporaryArray
                foreach (var c in currentArray)
                {
                    temporaryArray[temporaryIndex] = c;
                    temporaryIndex++;
                }

                foreach (var t in temporaryArray)
                {
                    Console.WriteLine(t);
                }
                
                // make new array with increased capacity
                
            }
            else
            {
                currentArray[count] = element;
                count++;
            }   
        }

        public void ExpandArray()
        {
            foreach (var a in currentArray)
            {
                Console.WriteLine(a);
            }
        }

    }
}
