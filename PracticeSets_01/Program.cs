﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSets_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.Write($"The number {num} is positive");
            }

            else
            {
                Console.WriteLine($"The number {num} is negative");
            }
        }
    }
}
