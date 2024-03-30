using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PriorityQueue queue = new PriorityQueue(5);
            queue.Enqueue(5);
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Print();
            Console.WriteLine("-----------");
        }
    }
}
