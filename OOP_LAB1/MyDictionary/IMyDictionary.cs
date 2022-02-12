using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1.MyDictionary
{
    interface IMyDictionary<TKey, TValue>
    {
        IEnumerable<TKey> Keys { get; }
        void Insert(TKey key, TValue value);
        TValue Get(TKey key);
        int Size();
        string ToString();
    }
}
