using System;
using System.Collections.Generic;

namespace DataStructures_And_Algorithms.Data_Structures.HashTable
{
    class FirstRecurringCharacter
    {
        /// <summary>
        /// Implementation using C#'s in-built HashSet data structure.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FirstRecurringInteger(int[] arr)
        {
            HashSet<int> hashSet = new HashSet<int>();
            for(int i=0;i<arr.Length;i++)
            {
                if (hashSet.Contains(arr[i]))
                    return arr[i];
                else
                {
                    hashSet.Add(arr[i]);
                }
            }
            //We are returning -99 in case we get no matches.
            return -99;
        }

        /// <summary>
        /// Implementation using custom HashTable data structure.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int FirstRecurringIntegerCustomHashTable(int[] arr)
        {
            HashTableImplementation<int, int> hashTable = new HashTableImplementation<int, int>(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashTable.Get(arr[i])>0)
                    return arr[i];
                else
                {
                    hashTable.Set(arr[i],1);
                }
            }
            //We are returning -99 in case we get no matches.
            return -99;
        }
    }
}
