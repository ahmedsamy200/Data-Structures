using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedList;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //OldLinkedList list = new OldLinkedList();
            //list.AddLast(5);
            //list.AddLast(6);
            //list.AddFirst(10);
            //list.AddLast(7);
            //list.AddLast(8);
            //list.RemoveFirst();
            //list.RemoveLast();
            //list.print();
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);
            list.AddFirst(1);
            list.AddLast(8);
            list.AddLast(9);
            list.print();
            Console.WriteLine("-----------------");
            list.DeleteNthFromTheEnd(1);
            list.print();
      

        }
    }
}
