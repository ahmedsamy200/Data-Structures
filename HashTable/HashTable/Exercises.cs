using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    //public class Exercises
    //{
    //    public char GetFirstNonReapted(string s)
    //    {
    //        Dictionary<char, int> dictionary = new Dictionary<char, int>();
            
    //        foreach (var item in s)
    //        {
                
    //            if(dictionary.ContainsKey(item))
    //            {
    //                int value = dictionary[item];
    //                value++;
    //                dictionary[item] = value;
    //            }
    //            else
    //            {
    //                dictionary.Add(item, 1);
    //            }
    //        }
            
    //        foreach (var item in dictionary)
    //        {
    //            if (item.Value == 1) return item.Key;
    //        }
    //        return Char.MinValue;
    //    }

    //    public char GetFirstReapted(string s)
    //    {
    //        Dictionary<char, int> dictionary = new Dictionary<char, int>();

    //        foreach (var item in s)
    //        {
    //            //var count = dictionary.ContainsKey(item) ? dictionary[item] : 0;
    //            //dictionary.Add(item, count + 1);
    //            if (dictionary.ContainsKey(item))
    //            {
    //                int value = dictionary[item];
    //                value++;
    //                dictionary[item] = value;
    //            }
    //            else
    //            {
    //                dictionary.Add(item, 1);
    //            }
    //        }
               
    //        foreach (var item in dictionary)
    //        {
    //            if (item.Value == 2) return item.Key;
    //        }
    //        return Char.MinValue;
    //    }

    //    public int hash(int number)
    //    {   
    //        return number % 100;
    //    }

    //    public int hash(string str)
    //    {
    //        int sum = 0;
    //        foreach (var item in str)
    //        {
               
    //            sum += item;
    //        }
    //        return sum % 100;
    //    }
    //}
}
