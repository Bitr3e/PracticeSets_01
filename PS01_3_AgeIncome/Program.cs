using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_3_AgeIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("age; ");
            int age = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Monthly income: ");
            int income = int.Parse(Console.ReadLine());

            if (age >= 25 && age <= 35 && income > 50000)
            {
                Console.WriteLine("Young Professional");
            }

            else if (age >= 36 && age <= 55 && income > 70000)
            {
                Console.WriteLine("Middle-Age Professional");
            }

            else if (age >= 56 && income < 30000)
            {
                Console.WriteLine("Senior Citizen");
            }

            else
            {
                Console.WriteLine("Other");
            }
        }
    }
}
