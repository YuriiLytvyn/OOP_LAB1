using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1.MyList
{
    interface IMyList<T>
    {
        void add(T item);
        T get(int index);
        void remove(int index);
        int size();

    }
}
