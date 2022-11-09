using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class SearchArray
    {
        public static void Search(int num)
        {
            var arr = new List<int> { 0, 1, 2, 3, 4,  5 };
            int cnt = 0;

            foreach(int elements in arr)
            {
                if (elements == num)
                {
                    Console.WriteLine("exists");
                    cnt = 1;
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
