using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    public class NumberOfVowels
    {
        public int CountVowels(string word)
        {  
            int counter = 0;
            foreach (var ch in word)
            {
                if (IsVowel(ch)) counter++;
            }
            return counter;
        }

        private bool IsVowel(char ch)
        {
            if (ch == 'a' || ch == 'u' || ch == 'o' || ch == 'i' || ch == 'e')
                return true;
            return false;
        }
    }
}
