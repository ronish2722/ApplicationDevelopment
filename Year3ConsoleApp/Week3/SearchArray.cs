using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class SearchArray
    {
        public static void Search(string val)
        {
            var arr = new List<string> { "apple", "banana", "mango" };
            int cnt = 0;

            foreach(string elements in arr)
            {
                if (String.Equals(val.ToLower(), elements.ToLower()))
                {
                    Console.WriteLine("exists");
                    cnt = 1; // to prevent multiple rendering of "not exist"
                    break;
                }
            }

            if (cnt != 1)
            {
                Console.WriteLine("not exist");
            }
        }
    }
}
