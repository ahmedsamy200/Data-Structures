using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Array numbers = new Array(3);
            numbers.insert(10);
            numbers.insert(20);
            numbers.insert(30);
            numbers.insert(40);
            numbers.insert(50);
            numbers.insert(60);
            numbers.insert(70);
            numbers.insert(80);
            numbers.insert(90);
            numbers.insert(100);
            numbers.print();
            Console.WriteLine("-------------------------");
            numbers.removeAt(6);
            numbers.removeAt(5);    
            
            numbers.print();

        }
    }
}
