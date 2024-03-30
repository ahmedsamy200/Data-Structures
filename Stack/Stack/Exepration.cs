using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Exepration
    {

        public bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>(10);
            foreach (var ch in input.ToCharArray())
            {
                if(isOpenBracket(ch))
                {
                    stack.Push(ch);
                }
                else if (isCloseBracket(ch))
                {
                    if (stack.IsEmpty()) return false;
                    char top = stack.Pop();
                    if (isNotMatched(ch , top))
                    {
                        return false;
                    }

                }
            }
            return stack.IsEmpty();
         
        }

        private bool isOpenBracket(char ch)
        {
            return ch == '(' || ch == '[' || ch == '{' || ch == '<';
        }

        private bool isCloseBracket(char ch)
        {
            return ch == ')' || ch == ']' || ch == '}' || ch == '>';
        }

        private bool isNotMatched(char ch , char top)
        {
            return ch == ')' && top != '(' ||
                   ch == ']' && top != '[' ||
                   ch == '}' && top != '{' ||
                   ch == '>' && top != '<';
        }
    }
}
