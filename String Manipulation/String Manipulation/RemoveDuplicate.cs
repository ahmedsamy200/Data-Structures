using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    public class RemoveDuplicate
    {
        public string RemoveDuplicates(string str)
        {
            StringBuilder res = new StringBuilder();
            HashSet<char> seen = new HashSet<char>();
            foreach (var ch in str)
            {
                if(!seen.Contains(ch))
                {
                    seen.Add(ch);
                    res.Append(ch);
                }
            }
            return res.ToString();
            //string res = "";
            //foreach (var ch in str)
            //{               
            //    if(!res.Contains(ch))
            //    {
            //        res += ch;
            //    }
            //}           
            //return res;
        }
    }
}
