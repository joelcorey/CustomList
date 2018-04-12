using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
     public class CustomList<T> : IEnumerable<T>, IComparable<CustomList<T>>
    {
        private T[] currentArray;
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

        public int CompareTo(CustomList<T> other)
        {
            // Returns:
            //     A value that indicates the relative order of the objects being compared. The
            //     return value has the following meanings: Value Meaning Less than zero This object
            //     is less than the other parameter.Zero This object is equal to other. Greater
            //     than zero This object is greater than other.
            if (this.Count == other.Count)
            {
                return 0;
            }
            else if (this.Count < other.Count)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int indexer { get; private set; }

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

        public void Remove(int remove)
        {
            T[] stagingArray = new T[count - 1];
            int stagingCount = 0;
            for (int i = 0; i < count; i++)
            {
                if (i != remove)
                {
                    stagingArray[stagingCount] = currentArray[i];
                    stagingCount++;
                }
            }
            count = stagingCount;
            currentArray = stagingArray;
        }

        public void ResizeArray()
        {
            capacity *= 2;
            T[] stagingArray = new T[capacity];
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
        public override String ToString()
        {
            String returnValue = String.Empty;
            foreach (T item in this)
            {
                if (String.IsNullOrEmpty(returnValue))
                    returnValue += item.ToString();
                else
                    returnValue += String.Format(", {0}", item);
            }
            return returnValue;
        }

        

        public static CustomList<T> operator +(CustomList<T> customList1, CustomList<T> customList2)
        {
            foreach (var item in customList2)
            {
                customList1.Add(item);
            }
            return customList1;
        }

        public static CustomList<T> operator -(CustomList<T> customList1, CustomList<T> customList2)
        {
            //TODO if else for comparing which list is longer? ..
            
            
            return customList1;
        }
    }
}
