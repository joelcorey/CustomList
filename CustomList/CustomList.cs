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
        private T[] stagingArray;
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
                ResizeArray();
            }
            currentArray[count] = element;
            count++;
        }

        public void ResizeArray()
        {
            capacity *= 2;
            stagingArray = new T[capacity];
            CopyArray(count - 1, stagingArray, currentArray);
            currentArray = stagingArray;
        }

        public void CopyArray(int limit, T[] destinationArray, T[] sourceArray)
        {
            for (int i = 0; i <= limit; i++)
            {
                if (i <= limit)
                {
                     destinationArray[i] = sourceArray[i];
                }
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
