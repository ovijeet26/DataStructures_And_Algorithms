
namespace DataStructures_And_Algorithms.Data_Structures.LinkedList
{
    class DoubleNode<T>
    {
        public T data { get; set; }

        public DoubleNode<T> next { get; set; }
        public DoubleNode<T> prev { get; set; }


        public DoubleNode(T data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
}
