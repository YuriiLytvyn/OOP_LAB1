using OOP_LAB1.MyDictionary;
using OOP_LAB1.MyList;
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
            IMyList<int> myList = new MyList<int>();
            myList.add(2);
            myList.add(3);
            myList.add(4);
            myList.add(5);
            myList.add(6);
            /*
            Console.WriteLine(myList.size());
            Console.WriteLine(myList.get(0));
            myList.remove(0);
            Console.WriteLine(myList.size());
            */

            int[] array = GetArray<int>.GetAttay((MyList<int>)myList);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            /*
            IMyDictionary<int, int> myDictionary = new MyDictionary<int, int>();
            myDictionary.Insert(1, 1);
            myDictionary.Insert(2, 2);
            myDictionary.Insert(3, 3);
            myDictionary.Insert(4, 4);
            myDictionary.Insert(5, 5);
            Console.WriteLine(myDictionary.Size());
            Console.WriteLine(myDictionary.Get(1));
            Console.WriteLine(myDictionary.Get(5));
            Console.WriteLine(myDictionary.Get(4));
            Console.WriteLine(myDictionary.Get(2));
            Console.WriteLine(myDictionary.Get(3));
            */

            Console.ReadKey();
            
        }
    }
}
