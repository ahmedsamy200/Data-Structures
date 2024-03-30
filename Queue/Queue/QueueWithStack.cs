using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class QueueWithStack<T>
    {
        Stack<T> stack1 = new Stack<T>();
        Stack<T> stack2 = new Stack<T>();

        public void Enqueue(T data)
        {
            stack1.Push(data);
        }

        public T Dequeue()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
                throw new Exception();

            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Pop();

        }

        public T Peek()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
                throw new Exception();

            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            return stack2.Peek();

        }

        public void Print()
        {
            foreach (var item in stack2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
