using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class CircularQueue<T>
    {
        T[] array;
        int front = 0, rear = 0;
        int count = 0;
        public CircularQueue(int size)
        {
            array = new T[size];
        }

        public void Enqueue(T data)
        {
            if (count == array.Length)
            {
                Console.WriteLine("The queue is full");
                return;
            }
            array[rear] = data;
            rear = (rear + 1) % array.Length;
            count++;

        }

        public T Dequeue()
        {
            if (count == 0) throw new ArgumentNullException("The Queue is Empty");
            T top = array[front];
            array[front] = default;
            front = (front + 1) % array.Length;
            count--;
            return top;
        }

        public void Reverse()
        {
            //[10 , 20 , 30] => [30 , 20 , 10]
            Stack<T> stack = new Stack<T>();
            for (int i = 0; i < count; i++)
            {
                stack.Push(array[i]);
            }
            for (int i = 0; i < count; i++)
            {
                array[i] = stack.Pop();
            }

        }

        public void Print()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
