using System;

namespace DataStructures_And_Algorithms.Data_Structures.Array
{
    /// <summary>
    /// This is an implementation of an Generic (T) Array.
    /// </summary>
    public class ArrayImplementation<T>
    {
        private T[] data;
        private int capacity;
        private int length;
        public ArrayImplementation()
        {
            this.capacity = 5;
            this.data = new T[capacity];
            this.length = 0;
        }
        /// <summary>
        /// Print the Array.
        /// </summary>
        public void Print()
        {
            Console.WriteLine();
            for(int i=0; i< this.length;i++)
            {
                Console.Write(this.data[i] + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Get Array data at a particular index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            //Throw some error message -> Requested index is greater than the length of the array.
            if (index >= this.length)
                return default(T);
            return this.data[index];
        }
        /// <summary>
        /// Insert into the array at the last position
        /// </summary>
        /// <param name="newData"></param>
        public void Push(T newData)
        {
            //Checking if the Array has enough space to store the new data.
            if (this.length + 1 >= this.capacity)
                IncreaseArrayCapacity();
            this.data[this.length] = newData;
            this.length++;
        }
        /// <summary>
        /// Delete the last element of the Array.
        /// </summary>
        public void Pop()
        {
            //Checking if the Array has at least one element to delete.
            if (this.length == 0)
                return;
            //Assigning the default int value (i.e. deleteing the last element)
            this.data[length - 1] = default(T);
            this.length--;
        }
        /// <summary>
        /// Delete element at a particular index of the Array.
        /// </summary>
        public void Delete(int index)
        {
            //Throw some error message -> Requested index is greater than the length of the array.
            if (index >= this.length)
                return;
            ShiftArrayElements(index);
        }
        /// <summary>
        /// Shift the array elements to delete an element.
        /// </summary>
        private void ShiftArrayElements(int index)
        {
            for(int i=index;i< this.length -1;i++)
            {
                this.data[i] = this.data[i + 1];
            }
            //Assigning the default int value (i.e. deleteing the last element)
            this.data[this.length - 1] = default(T);
            //Decreasing the length of the Array.
            this.length--;
        }
        /// <summary>
        /// Double the existing capacity of the Array.
        /// </summary>        
        private void IncreaseArrayCapacity()
        {
            //Doubling the existing Array capacity to accomodate new data.
            this.capacity *= 2;
            T[] newArray = new T[this.capacity];
            //Copy the contents of the data Array to the new Array.
            System.Array.Copy(this.data, newArray, (this.capacity / 2));
            this.data = newArray;
        }
    }
}
