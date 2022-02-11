using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.add(2);
            myList.add(3);
            myList.add(4);
            myList.add(5);
            myList.add(6);
            Console.WriteLine(myList.size());
            Console.WriteLine(myList.get(0));
            myList.remove(0);
            Console.WriteLine(myList.size());
            Console.ReadKey();
        }
    }
}
