﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            if (num1 < 0 || num1 > 0)
            {
                Console.WriteLine($"{num1}:{-num1}");
            }
            else
            {
                Console.WriteLine($"{num1}:{num1}");
            }
            Console.ReadKey();


        }
    }
}
