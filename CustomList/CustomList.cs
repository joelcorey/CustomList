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
        private T[] newArray = new T[4];
        private int count;

        //public void Customlist(T value)
        //{
        //    this.value = value;
        //}

        public void Add(T element)
        {
            this.newArray[count++] = element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return newArray.Take(count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
