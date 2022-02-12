using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1.MyClass
{
    class MyClass<T>  where T : class, new()
    {
        public static T FacrotyMethod()
        {
            T t = new T();
            return t;
        }

    }
}
