using System;
using DataStructures_And_Algorithms.Data_Structures.Array;
using DataStructures_And_Algorithms.Data_Structures.HashTable;

namespace DataStructures_And_Algorithms
{
    class Executor
    {
        static void Main(string[] args)
        {
            //Arrays
            //IntegerArrayImplementaion();
            //ReverseString();
            //MergeArrays();

            //Hash Table

            StringHashTableImplementaion();
        }
        private static void IntegerArrayImplementaion()
        {
            ArrayImplementation<int> array = new ArrayImplementation<int>();
            array.Push(1);
            array.Push(2);
            array.Push(3);
            array.Push(4);
            array.Push(5);
            array.Push(6);
            array.Print();
            array.Pop();
            array.Pop();
            array.Print();
            array.Delete(0);
            array.Print();
            array.Delete(1);
            array.Print();
            Console.WriteLine(array.Get(1));
            Console.ReadKey();
        }
        private static void ReverseString()
        {
            StringReverse sr = new StringReverse();
            Console.WriteLine(sr.Reverse("Hi my name is Ovijeet"));
            Console.ReadKey();
        }
        private static void MergeArrays()
        {
            MergeSortedArrays m = new MergeSortedArrays();
            int[] firstArr = { 0, 3, 4, 31 };
            int[] secondArr = { 4, 6, 30 };
            int[] mergedArr = m.Merge(firstArr, secondArr);
            Print(mergedArr);
            Console.ReadKey();
        }
        private static void Print(int[] arr)
        {
            Console.WriteLine();
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
        }

        private static void StringHashTableImplementaion()
        {
            HashTableImplementation <string,int> ht = new HashTableImplementation<string,int>(2);
            ht.Set("Grapes", 1000);


            ht.Set("Apple", 10);
            ht.Set("Apples", 10099);
            var getValue = ht.Get("Apple");
            Console.ReadKey();
        }

    }
}
