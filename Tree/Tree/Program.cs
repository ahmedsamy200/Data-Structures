using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(8);
            tree.Add(3);
            tree.Add(10);
            tree.Add(1);
            tree.Add(6);
            tree.Add(4);
            //tree.InOrder();
            tree.LevelOrder();
            //Console.WriteLine(tree.IsBST());
        }
    }
}
