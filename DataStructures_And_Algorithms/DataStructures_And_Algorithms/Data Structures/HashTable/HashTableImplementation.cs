using System.Collections.Generic;

namespace DataStructures_And_Algorithms.Data_Structures.HashTable
{
    /// <summary>
    /// This is an implementation of an Generic Hash Table.
    /// </summary>
    class HashTableImplementation<Key, Value>
    {
        private List<Data<Key, Value>>[] data;
        private int size;
        public HashTableImplementation(int size)
        {
            this.size = size;
            this.data = new List<Data<Key, Value>>[size];
        }
        /// <summary>
        /// Set a value to the Hash  Table.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Set(Key key, Value value)
        {
            int index = Hash(key);
            //Initialize the List if there's no previous values stored.
            if (this.data[index] == null)
            {
                this.data[index] = new List<Data<Key, Value>>();
            }
            this.data[index].Add(new Data<Key, Value>()
            {
                KeyData = key,
                ValueData = value
            });
        }
        /// <summary>
        /// Get a Value from the Hash Table.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Value Get(Key key)
        {
            int index = Hash(key);
            var currentBucket = this.data[index];
            if (currentBucket!=null)
            {
                foreach (var item in currentBucket)
                {
                    //Return the value if a match is found.
                    if (item.KeyData.Equals(key))
                    {
                        return item.ValueData;
                    }
                }
            }
            return default(Value);
        }
        /// <summary>
        /// Return a List of Keys of the Hash Table.
        /// </summary>
        /// <returns></returns>
        public List<Key> Keys()
        {
            List<Key> keys = new List<Key>();
            foreach(var bucket in this.data)
            {
                if (bucket == null)
                    continue;
                foreach (var item in bucket)
                {
                    keys.Add(item.KeyData);
                }
            }
            return keys;
        }
        /// <summary>
        /// Return a List of Values of the Hash Table.
        /// </summary>
        /// <returns></returns>
        public List<Value> Values()
        {
            List<Value> values = new List<Value>();
            foreach (var bucket in this.data)
            {
                if (bucket == null)
                    continue;
                foreach (var item in bucket)
                {
                    values.Add(item.ValueData);
                }
            }
            return values;
        }
        /// <summary>
        /// Private hash function to generate an index value from the Key.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        private int Hash(Key key)
        {
            int hash = 0;
            string keyString = key.ToString();
            for (int i = 0; i < keyString.Length; i++)
            {
                hash = (hash + (int)keyString[i] * i) % this.data.Length;
            }
            return hash;
        }
    }
    //Generic class for storing the Hash Table data
    class Data<Key, Value>
    {
        public Key KeyData { get; set; }
        public Value ValueData { get; set; }
    }
}
