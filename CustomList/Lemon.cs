using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Lemon
    {
        private int value;

        public Lemon(Random random)
        {
            this.value = random.Next(1, 100);
        }

        public int Value
        {
            get
            {
                return value;
            }
        }
    }
}
