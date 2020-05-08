using System;

namespace DataStructures_And_Algorithms.Data_Structures.Array
{
    class MergeSortedArrays
    {
        public int[] Merge(int[] a, int[] b)
        {
            //If either the first or the second array is empty, we return the other array as the result.
            if (a.Length == 0)
                return b;
            if (b.Length == 0)
                return a;
            //Creating a merged Array of the required length.
            int[] mergeArray = new int[a.Length + b.Length];
            int aIndex = 0;
            int bIndex = 0;
            for(int i=0;i<mergeArray.Length;i++)
            {
                if(aIndex>=a.Length)
                {
                    mergeArray[i] = b[bIndex];
                    bIndex++;
                }
                else if(bIndex>=b.Length)
                {
                    mergeArray[i] = a[aIndex];
                    aIndex++;
                }
                else if(a[aIndex]<=b[bIndex])
                {
                    mergeArray[i] = a[aIndex];
                    aIndex++;
                }
                else
                {
                    mergeArray[i] = b[bIndex];
                    bIndex++;
                }
            }
            return mergeArray;
        }
    }
}
