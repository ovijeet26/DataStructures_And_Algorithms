using System;

namespace DataStructures_And_Algorithms.Data_Structures.LinkedList
{
    class DoublyLinkedList<T>
    {
        private DoubleNode<T> head;
        private DoubleNode<T> tail;
        private int length;
        public DoublyLinkedList(T data)
        {
            head = new DoubleNode<T>(data);
            tail = head;
            length = 1;
        }

        /// <summary>
        /// Append an element to the end of the Linked List.
        /// </summary>
        /// <param name="data"></param>
        public void Append(T data)
        {
            DoubleNode<T> newNode = new DoubleNode<T>(data);
            this.tail.next = newNode;
            newNode.prev = this.tail;
            this.tail = newNode;
            this.length++;
        }

        /// <summary>
        /// Prepend an element to the end of the Linked List.
        /// </summary>
        /// <param name="data"></param>
        public void Prepend(T data)
        {
            DoubleNode<T> newNode = new DoubleNode<T>(data);
            newNode.next = this.head;
            this.head.prev = newNode;
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
                DoubleNode<T> pointer = TraverseToIndex(index - 1);
                DoubleNode<T> newNode = new DoubleNode<T>(data);
                newNode.next = pointer.next;
                pointer.next.prev = newNode;
                newNode.prev = pointer;
                pointer.next = newNode;
            }
            this.length++;
        }

        public void Remove(int index)
        {
            //If index is larger than the size of the Linked list, its an error.
            if (index > length)
            {
                return;
            }
            //Need to delete head
            else if (index == 0)
            {
                head = head.next;
            }
            else
            {
                DoubleNode<T> pointer = TraverseToIndex(index - 1);
                pointer.next = pointer.next.next;
                pointer.next.prev = pointer;
            }
            this.length--;
        }
        /// <summary>
        /// Helper method to traverse to a particular index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private DoubleNode<T> TraverseToIndex(int index)
        {
            DoubleNode<T> pointer = this.head;
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
            Console.Write(" NULL ");
            DoubleNode<T> pointer = this.head;
            while (pointer.next != null)
            {
                Console.Write(" <- " + pointer.data + " -> ");
                pointer = pointer.next;
            }
            Console.Write("NULL");
        }
    }
}
