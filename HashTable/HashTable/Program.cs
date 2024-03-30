using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet<int> sh = new HashSet<int>();
            //Dictionary<int, string> di =new Dictionary<int, string>();
            //di.Add(1, "ahmed");
            //di.Add(2, "ali");
            //di.Add(3, "sara");

            //foreach (var item in di)
            //{
            //    Console.WriteLine($"Key: {item.Key} \t Value: {item.Value}");
            //}
            //Hashtable ht = new Hashtable();
            //ht.Add(1, 2);
            //ht.Add("2", 1);
            //ht.Add(4, 6);
            //ht.Add(3, 3);
            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine("Key: {0} and Value: {1} ",
            //                  item.Key, item.Value);
            //}
            //Exercises exercises = new Exercises();
            //char c = exercises.GetFirstReapted("a green apple");
            //int z = exercises.hash("123456-A");
            //Console.WriteLine(z);
            //int[] arr = { 1, 2, 0, 0 };
            //var d = AddToArrayForm(arr, 34);
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(6, "ahmed");
            dictionary.Add(4, "ali");
            dictionary.Add(3, "said");
            dictionary.Add(11, "mm");
            dictionary.Add(12, "sa");
            dictionary.Add(13, "sa");
            dictionary.Add(14, "sa");
            dictionary.Add(15, "sa");
           
        }

        public static IList<int> AddToArrayForm(int[] num, int k)
        {
            int len = num.Length - 1;
            List<int> result = new List<int>();
            while (len >= 0 || k != 0)
            {

                if (len >= 0)
                {
                    k += num[len--];
                }

                result.Add(k % 10);
                k /= 10;
            }
            result.Reverse();
            return result;
        }
    }
}
