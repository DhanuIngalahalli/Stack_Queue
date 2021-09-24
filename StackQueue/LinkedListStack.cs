using System;
using System.Collections.Generic;
using System.Text;

namespace StackQueue
{
    class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        /// <summary>
        /// create push method
        /// </summary>
        /// <param name="value"></param>
        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);
        }
        /// <summary>
        /// create display method
        /// </summary>
        public void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
