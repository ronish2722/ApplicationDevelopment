using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class Swap
    {
        public static void Swapping(int num1, int num2)
        {
            Console.WriteLine("First num: " + num1);
            Console.WriteLine("First num: " + num2);
            Console.WriteLine("After swapping: ");

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("First num: " + num1);
            Console.WriteLine("First num: " + num2);
        }
    }
}
