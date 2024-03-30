using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataStructure
{
    public class Array
    {
        private int[] arr;
        private int count = 0;     
        public Array(int length)
        {
            arr =new int[length];
        }

        public void insert(int item)
        {
            // if array is full , resize it
            if (count == arr.Length)
            {
                int[] newarr = new int[count * 2];

                // copy all the existing items      
                for (int i = 0; i < count; i++)
                {
                    newarr[i] = arr[i];
                }
                //set items to this new array
                arr = newarr;
            }

            arr[count] = item;
            count++;
        }

        public void removeAt(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();

            for (int i = index; i < count; i++)
            {            
                arr[i] = arr[i + 1];
            }
            count--;
        }

        public void print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
