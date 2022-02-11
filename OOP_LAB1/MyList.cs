using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1
{
    class MyList<T>
    {
        const int INIT_SIZE = 16;
        const int CUT_RATE = 4;
        private Object[] array = new Object[INIT_SIZE];
        private int pointer = 0;

        public void add(T item)
        {
            if (pointer == array.Length - 1)
            {
                resize(array.Length * 2);
            }
            array[pointer++] = item;
        }

        public T get(int index)
        {
            return (T)array[index];
        }

        public void remove(int index)
        {
            for(int i = index; i<index; i++)
            {
                array[i] = array[i + 1];
            }
            array[pointer] = null;
            pointer--;
            if (array.Length > INIT_SIZE && pointer < array.Length / CUT_RATE)
            {
                resize(array.Length / 2);
            }
        }

        public int size()
        {
            return pointer;
        }

        private void resize(int newLeght)
        {
            Object[] newArray = new Object[newLeght];
            Array.Copy(array, newArray, newLeght);
            array = newArray;
        }
    }
}
