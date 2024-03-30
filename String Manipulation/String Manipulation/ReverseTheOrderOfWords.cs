using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    public class ReverseTheOrderOfWords
    {
        public string Reverse(string str)
        {
            string[] s = str.Split(' ');            
            StringBuilder res = new StringBuilder();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                res.Append(s[i] + ' ');
            }
            return res.ToString();
        }
    }
}
