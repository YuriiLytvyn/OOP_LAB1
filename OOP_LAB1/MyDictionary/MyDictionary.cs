using OOP_LAB1.MyDictionary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB1
{
    class MyDictionary<TKey, TValue> : IMyDictionary<TKey, TValue>
    {
        private const int SIZE = 4;
        private const int TCOUNT = 2;

        private object[] arraysLock;
        private Node<TKey, TValue>[] buckets;

        private int pointer = 0;

        public MyDictionary()
        {
            buckets = new Node<TKey, TValue>[SIZE];
            arraysLock = new object[TCOUNT];

            for(int i = 0; i<arraysLock.Length; i++)
            {
                arraysLock[i] = new object();
            }
        }

        public IEnumerable<TKey> Keys
        {
            get
            {
                foreach (Node<TKey, TValue> bucket in buckets){
                    Node<TKey, TValue> node = bucket;
                    while(node != null)
                    {
                        yield return node.key;
                        node = node.next;
                    }
                }
            }
        }

        public void Insert(TKey key, TValue value)
        {

            int hashcode = key.GetHashCode();
            int lockId = GetLockId(hashcode);

            lock (arraysLock[lockId])
            {
                Node<TKey, TValue> entryObj = new Node<TKey, TValue>( value , key);
                int bucketId = GetBucketId(hashcode);
                InsertInternal(entryObj, bucketId);
            }
            pointer++;
        }
        private void InsertInternal(Node<TKey, TValue> entry, int bucketId)
        {
            Node<TKey, TValue> firstEntry = buckets[bucketId];
            if (firstEntry == null)
            {
                firstEntry = entry;
            }
            else
            {
                entry.next = firstEntry;
                firstEntry = entry;
            }

            buckets[bucketId] = firstEntry;
        }

        private int GetLockId(int hashcode)
        {
            return hashcode & (TCOUNT - 1);
        }

        private int GetBucketId(int hashcode)
        {
            return hashcode & (SIZE - 1);
        }

        public TValue Get(TKey key)
        {
            int hashcode = key.GetHashCode();
            int lockId = GetLockId(hashcode);

            lock (arraysLock[lockId])
            {
                int bucketId = GetBucketId(hashcode);
                Node<TKey, TValue> tempEntry = buckets[bucketId];
                while (tempEntry != null && !tempEntry.key.Equals(key))
                {
                    tempEntry = tempEntry.next;
                }


                if (tempEntry != null)
                {
                    return tempEntry.value;
                }
                return tempEntry.value;
            }

        }

        public int Size()
        {
            return pointer;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (TKey key in Keys)
            {
                sb.AppendLine(key + " (" + GetBucketId(key.GetHashCode()) + ") " + " [" + key.GetHashCode() + "] " + " => " + this.Get(key));
            }

            return sb.ToString();
        }
    }

}
