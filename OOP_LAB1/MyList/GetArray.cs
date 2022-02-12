using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_LAB1.MyList;

namespace OOP_LAB1.MyList
{
    static class GetArray<T>
    {
        public static T[] GetAttay( MyList<T> list)
        {
            int leght = list.size();
            T[] array = new T[leght];
            for (int i = 0; i < leght; i++)
            {
                array[i] = list.get(i);
            }
            return array;
        }
    }
}
