﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week3
{
    internal class Prime
    {
        public static void IsPrime(int num)
        {
            if (num <= 1)
            {
                Console.WriteLine("Not applicable");
                return;
            }

            int cnt = 0;

            for (int i = 2; i <= num; i ++)
            {
                if (num % i == 0)
                {
                    cnt = cnt + 1;
                }
            }
            if (cnt > 2)
            {
                Console.WriteLine("not prime");
            }
            else
            {
                Console.WriteLine("prime");
            }
        }
    }
}
