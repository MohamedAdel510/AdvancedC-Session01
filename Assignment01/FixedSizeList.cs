using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    internal class FixedSizeList<T>
    {
        private T[] array;
        private int cap;
        private int numOfItem;

        public FixedSizeList(int cap)
        {
            this.cap = cap;
            numOfItem = 0;
            array = new T[this.cap];
        }

        public void Add(T value)
        {
            try
            {
                array[numOfItem] = value;
                numOfItem++;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public T Get(int index)
        {
            if (index > cap)
                throw new IndexOutOfRangeException();
            return array[index];

        }

        public void Print()
        {
            for(int i = 0; i < numOfItem; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
