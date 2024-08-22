using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_2_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("odd or even number: ");
            int num = int.Parse(Console.ReadLine());
            int even = 2%10000;

            if (num == even)
            {
                Console.WriteLine($"The number {num} is even");
            }

            else
            {
                Console.WriteLine($"The number {num} is odd");
            }
        }
    }
}
