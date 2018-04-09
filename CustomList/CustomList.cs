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
        private T[] currentArray = new T[4];
        private int count;

        //public void Customlist(T value)
        //{
        //    this.value = value;
        //}

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
            this.currentArray[count++] = element;
        }

        //public void Length()
        //{
        //    private int 
        //}
    }
}
