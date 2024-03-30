using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    public class ReverseAString
    {
        public string Reverse(string str)
        {
            // by iteration
            StringBuilder res = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                res.Append(str[i]);
            }
            return res.ToString();

            // by stack
            //Stack<char> stack = new Stack<char>();
            //foreach (var ch in str)
            //{
            //    stack.Push(ch);
            //}
            //string res = "";
            //while(stack.Count > 0)
            //{
            //    res += stack.Pop();
            //}
            //return res;

            //by recursion
            //return Reverse(str, "");
        }

        //by recursion
        private string Reverse(string str , string res)
        {
            if (str.Length == 0) return res;
            res += str[str.Length - 1];
            return Reverse(str.Substring(0, str.Length - 1), res);
        }
    }
}
