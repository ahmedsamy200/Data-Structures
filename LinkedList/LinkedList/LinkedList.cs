using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   public class LinkedList<T>
    {
      
         class Node
        {
            public T value;
            public Node next;
            public Node(T value)
            {
                this.value = value;
                next = null;
            }
        }

        Node first;
        Node last;
        int counter = 0;
        public void AddLast(T value)
        {
            Node node = new Node(value);
            if (first == null)
            {
                first = last = node;
            }
            else
            {
                last.next = node;
                last = node;
            }
            counter++;
        }

        public void AddFirst(T value)
        {
            Node node = new Node(value);
            if (first == null)
            {
                first = last = node;
            }
            else
            {
                node.next = first;
                first = node;
            }
            counter++;
        }

        public void RemoveFirst()
        {
            if (first == null)
            {
                throw new InvalidOperationException("The List is empty");
            }
            if (first == last)
            {
                first = last = null;
            }
            else
            {
                Node second = first.next;
                first.next = null;
                first = second;

            }
            counter--;
        }

        public void RemoveLast()
        {
            if (first == null)
            {
                throw new InvalidOperationException("The List is empty");
            }
            if (first == last)
            {
                first = last = null;
                
            }
            else
            {
                Node previous = getPrevoius(last);
                previous.next = null;
                last = previous;
            }

            counter--;
        }

        public int size()
        {      
            return counter;
        }

        public T[] ToArray()
        {
            T[] array = new T[counter];
            int index = 0;
            Node current = first;
            while (current != null)
            {
                array[index] = current.value;
                current = current.next;
                index++;
            }
            return array;
        }

        public void Revirse()
        {
            if (first == null) return;

            Node previous = null, current = first, next = null;
            while (current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
            }
            last = first;
            last.next = null;
            first = previous;       
        }


        public T GetNthFromTheEnd(int n)
        {
            if (n > counter || n < 1 || first == null) 
                throw new InvalidOperationException("the index is out of range");
           
            int k = counter - n + 1;
           
            T target = first.value;
            Node current = first;
            for (int i = 0; i < k; i++)
            {
                target = current.value;
                current = current.next;
            }
            return target;
        }

        public void DeleteNthFromTheEnd(int n )
        {
            if (n > counter || n < 1 || first == null)
                throw new InvalidOperationException("the index is out of range");

            int k = counter - n + 1;

            Node target = first;
            Node current = first;
            for (int i = 0; i < k; i++)
            {
                target = current;
                current = current.next;
            }

            Node previous = getPrevoius(target);
            previous.next = target.next;
            target.next = null;
            counter--;
        }


        public void print()
        {
            Node current = first;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }



        private Node getPrevoius(Node node)
        {
            Node current = first;
            while (current != null)
            {
                if (current.next == node)
                {
                    return current;
                }
                current = current.next;
            }
            return null;
        }
    }
}
