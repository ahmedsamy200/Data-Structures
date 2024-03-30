using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class PriorityQueue
    {
        int[] array;
        int count;
        public PriorityQueue(int size)
        {
            array = new int[size];
        }

        public void Enqueue(int data)
        {
            if (count == array.Length)
               throw new Exception();

            int i;
            for (i = count - 1; i >= 0; i--)
            {
                if (data < array[i])
                {
                    array[i + 1] = array[i];
                }
                else
                    break;
            }
            array[i + 1] = data;
            count++;
        }

        public int Dequeue()
        {
            if (count == 0)
                throw new Exception();
            return array[--count];
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
