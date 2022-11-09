using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class OddOrEven
    {
        public static void CheckOddEven(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("neither");
                return;
            }

            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else {
                Console.WriteLine("Odd");
            }
        }
    }
}
