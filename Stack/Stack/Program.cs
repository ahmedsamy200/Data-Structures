using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            StackUsingLinkedList<int> stack = new StackUsingLinkedList<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Print();

            Console.WriteLine("---------------");
            stack.Pop();
            stack.Print();
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine("---------------");
            Console.WriteLine(stack.Peek());
            //Exepration exepration = new Exepration();
            //Console.WriteLine(exepration.IsBalanced("<5+6>"));


        }
    }
}
