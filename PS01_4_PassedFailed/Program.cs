using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_4_PassedFailed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exam score: ");
            int score = int.Parse(Console.ReadLine());

            string result = (score >= 50) ? "Passed" : "Failed";
            Console.WriteLine($"Result: {result}");
        }
    }
}
