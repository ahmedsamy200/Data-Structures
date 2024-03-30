using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackUsingLinkedList<T>
    {
        Node head;
       private class Node
        {
            public T value;
            public  Node next;
            public Node(T value)
            {
                this.value = value;
                next = null;
            }
        }

        public void Push(T value)
        {
            Node node = new Node(value);
            node.next = head;
            head = node;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("the stack is empty");
            head = head.next;
            return head.value;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new ArgumentOutOfRangeException("the stack is empty");
            return head.value;
        }

        public bool IsEmpty() => head == null;

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }
}
