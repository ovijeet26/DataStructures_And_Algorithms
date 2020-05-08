using System;

namespace DataStructures_And_Algorithms.Data_Structures.Array
{
    /// <summary>
    /// This is an implementation of a class to reverse a string.
    /// </summary>
    public class StringReverse
    {
        /// <summary>
        /// Reverse a string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public string Reverse(string str)
        {
            if(String.IsNullOrEmpty(str))
            {
                return "Null/Empty String.";
            }
            //Convert the String to a Character Array.
            char[] stringArray = str.ToCharArray();
            int halfLength = str.Length / 2;
            //Traversing just half the array to effectively Swap the last and the first elements.
            for (int i=0;i<halfLength;i++)
            {
                Swap(i, str.Length - 1 - i, stringArray);
            }
            return new string(stringArray);
        }
        /// <summary>
        /// Swap two elements of a Character Array.
        /// </summary>
        /// <param name="pos1"></param>
        /// <param name="pos2"></param>
        /// <param name="str"></param>
        private void Swap(int pos1, int pos2, char[] str)
        {
            var temp = str[pos1];
            str[pos1] = str[pos2];
            str[pos2] = temp;
        }
    }
}
