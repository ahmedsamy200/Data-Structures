using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
   public class Dictionary<TKey, TValue>
    {
        public class KeyValuePair
        {
            public TKey key;
            public TValue value;
            public KeyValuePair(TKey key, TValue value)
            {
                this.key = key;
                this.value = value;
            }
        }

        LinkedList<KeyValuePair>[] arr;

        public Dictionary()
        {
            arr = new LinkedList<KeyValuePair>[5];
        }

        public void Add(TKey key, TValue value)
        {
            int index = hash(key);
            if (arr[index] == null)
                arr[index] = new LinkedList<KeyValuePair>();

            foreach (var item in arr[index])
            {
                if (item.key.Equals(key)) throw new InvalidOperationException("the key cant Duplicated");
            }
            KeyValuePair keyValuePair = new KeyValuePair(key, value);
            arr[index].AddLast(keyValuePair);
        }

        public TValue Get(TKey key)
        {
            int index = hash(key);
            foreach (var item in arr[index])
            {
                if (item.key.Equals(key)) return item.value;
            }
            throw new InvalidOperationException("the key not found");
        }

        public void Delete(TKey key)
        {
            int index = hash(key);
            if (arr[index] == null) throw new InvalidOperationException("the key not found");

            foreach (var item in arr[index])
            {
                if (item.key.Equals(key))
                {
                    arr[index].Remove(item);
                    return;
                }
            }
        }

        public void Print()
        {
         
        }

        private int hash(TKey key)
        {
            int hash = 0;
            foreach (var item in key.ToString())
            {
                hash += item;
            }
            return hash % arr.Length;
        }
    }           
}
