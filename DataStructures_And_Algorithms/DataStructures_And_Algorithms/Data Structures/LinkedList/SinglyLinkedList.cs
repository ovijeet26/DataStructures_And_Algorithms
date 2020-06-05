using System;
namespace DataStructures_And_Algorithms.LinkedList
{
    class SinglyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int length;
        public SinglyLinkedList(T data)
        {
            head = new Node<T>(data);
            tail = head;
            length = 1;
        }
       
        /// <summary>
        /// Append an element to the end of the Linked List.
        /// </summary>
        /// <param name="data"></param>
        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);
            this.tail.next = newNode;
            this.tail = newNode;
            length++;
        }

        /// <summary>
        /// Prepend an element to the end of the Linked List.
        /// </summary>
        /// <param name="data"></param>
        public void Prepend(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = this.head;
            this.head = newNode;
            length++;
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="data"></param>
        /// <param name="index"></param>
        public void Insert(T data, int index)
        {
            //If index is larger than the size of the Linked list, its an error.
            if (index > length)
            {
                return;
            }
            //If the element to be inserted is the first element, we simply Prepend it.
            else if (index == 0)
            {
                Prepend(data);
            }
            //If the element to be inserted is the last element, we simply Append it.
            else if (index == length)
            {
                Append(data);
            }
            else
            {
                Node<T> pointer = TraverseToIndex(index - 1);
                Node<T> newNode = new Node<T>(data);
                newNode.next = pointer.next;
                pointer.next = newNode;
            }
            this.length++;
        }
        /// <summary>
        /// Remove a node at the particular index.
        /// </summary>
        /// <param name="index"></param>
        public void Remove(int index)
        {
            //If index is larger than the size of the Linked list, its an error.
            if (index > length)
            {
                return;
            }
            //Need to delete head
            else if(index==0)
            {
                head = head.next;
            }
            else
            {
                Node<T> pointer = TraverseToIndex(index - 1);
                pointer.next = pointer.next.next;
            }
            this.length--;
        }
        /// <summary>
        /// Reverse a Linked List
        /// </summary>
        public void Reverse()
        {
            if (this.head.next == null)
                return;
            Node<T> prev = null;
            Node<T> next = this.head;
            Node<T> current = this.head;

            while(next!=null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            this.head = prev;

        }
        /// <summary>
        /// Helper method to traverse to a particular index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private Node<T> TraverseToIndex(int index)
        {
            Node<T> pointer = this.head;
            int counter = 0;
            while (counter != index)
            {
                pointer = pointer.next;
                counter++;
            }
            return pointer;
        }
        /// <summary>
        /// Print the contents of the Linked List.
        /// </summary>
        public void PrintList()
        {
            Console.WriteLine();
            Node<T> pointer = this.head;
            while(pointer!=null)
            {
                Console.Write(pointer.data+" -> ");
                pointer = pointer.next;
            }
            Console.Write("NULL");
        }
    }
}
