using OOP_LAB1.MyList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1
{
    class MyList<T> : IMyList<T>
    {
        private const int INIT_SIZE = 16;
        private const int CUT_RATE = 4;
        private Object[] array = new Object[INIT_SIZE];
        private int pointer = 0;

        /**Adds a new element to the list. When the size of the internal
         array is reached, it is doubled.*/
        public void add(T item)
        {
            if (pointer == array.Length - 1)
            {
                resize(array.Length * 2);//increase by 2 times if you have reached the borders
            }
            array[pointer++] = item;
        }

        
        public T get(int index) //Returns the element of the list by index.
        {
            return (T)array[index];
        }
        /*
        Removes an element from the list by index. All elements to the right of the one being removed
        are moved one step to the left. If, after removing an element, the number of elements 
        became CUT_RATE times less than the size of the internal array,
        then the internal array is halved to save space.
        */
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
                resize(array.Length / 2); // if the elements in CUT_RATE are less than
                                          //the length of the array, then I will reduce it by half
            }
        }
        /*Returns the number of elements in the list*/
        public int size()
        {
            return pointer;
        }
        /*Helper method for scaling.*/
        private void resize(int newLeght)
        {
            Object[] newArray = new Object[newLeght];
            Array.Copy(array, newArray, newLeght);
            array = newArray;
        }
    }
}
