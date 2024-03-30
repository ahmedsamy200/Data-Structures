using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    public class StringIsARotationOfAnotherString
    {
        // ABCD -> DABC
        //      -> CDAB
        //      -> BCDA
        //      -> ABCD
        public bool AreRotations(string s1 , string s2)
        {
            if (s1 == null || s2 == null) return false;
            return (s1.Length == s2.Length && (s1 + s1).Contains(s2));
        }

    }
}
