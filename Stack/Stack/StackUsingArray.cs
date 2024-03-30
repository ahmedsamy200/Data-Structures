using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackUsingArray<T>
    {
        T[] array;
        int top = -1;
        public StackUsingArray(int size)
        {
            array = new T[size];
        }

        public void Push(T item)
        {
            top++;
            if (top >= array.Length)
            {
                T[] newArray = new T[top * 2];
                for (int i = 0; i < top; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
            array[top] = item;

        }

        public T Peek()
        {
            var value = array[top];
            return value;
        }

        public T Pop()
        {
            T value = array[top];
            top--;
            return value;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

     

        public void Print()
        {
            for (int i = top; i > -1 ; i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
