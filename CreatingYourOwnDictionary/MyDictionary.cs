using System;
using System.Collections.Generic;
using System.Text;

namespace CreatingYourOwnDictionary
{
    class MyDictionary<K, V>
    {
        K[] keys;
        V[] values;
        public MyDictionary()
        {
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K customerId, V customerName)
        {
            K[] tempKeys = keys;
            V[] tempValues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int i = 0; i < tempValues.Length; i++)
            {
                values[i] = tempValues[i];
            }
            keys[keys.Length - 1] = customerId;
            values[values.Length - 1] = customerName;


        }
        public int Count
        {
            get { return keys.Length; }
        }
        public void ShowKeysValues()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine("Key: {0}        Value: {1} ", keys[i], values[i]);
            }
        }
    }
}
