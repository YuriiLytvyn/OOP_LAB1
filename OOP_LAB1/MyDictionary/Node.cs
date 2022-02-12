using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1.MyDictionary
{
    class Node<TKey, TValue>
    {
        public TKey key { get; }
        public TValue value { get; set; }

        public Node<TKey, TValue> next { get; set; }
public Node(TValue _value , TKey _key)
        {
            value = _value;
            key = _key;
        }
    }

}

