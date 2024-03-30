using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplicate vowels = new RemoveDuplicate();
            Console.WriteLine(vowels.RemoveDuplicates("Hellooo!!"));
        }
    }
}
