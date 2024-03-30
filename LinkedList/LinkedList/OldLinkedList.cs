using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class OldLinkedList
    {
        
        private OldNode first;
        private OldNode last;

        public void AddFirst(int value)
        {
            OldNode newNode = new OldNode(value);
            if (first == null)
                first = last = newNode;
            else
            {
                newNode.next = first;
                first = newNode;
            }
           
        }

        public void AddLast(int value)
        {
            OldNode newNode = new OldNode(value);
            if (first == null)
                first = last = newNode;
            else
            {
                last.next = newNode;
                last = newNode;
            }
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
                return;
            }

            var second = first.next;
            first.next = null;
            first = second;
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
                return;
            }
            var previous = GetPrevious(last);
            last = previous;
            last.next = null;
        }

        public int indexOf(int item)
        {
            int index = 0;
            OldNode current = first;
            while (current != null)
            {
                if (current.value == item) return index;
                current = current.next;
                index++;
            }
            return -1;
        }

        public bool contains(int item)
        {
            return indexOf(item) != -1;        
        }

        public void print()
        {
            OldNode current = first;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }

        private OldNode GetPrevious(OldNode node)
        {
            var current = first;
            while (current != null)
            {
                if (current.next == last) return current;

                current = current.next;
            }
            return null;
        }
    }
}
