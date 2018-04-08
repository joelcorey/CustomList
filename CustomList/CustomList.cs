using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        private T value;

        public void Clist(T value)
        {
            this.value = value;
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.Value = value;
            }
        }

        public void Add(ref T value)
        {

        }

        public int Count(T value)
        {
            int count = 0;
            foreach (T v in value)
            {

            }
            return count;
        }
    }
}
