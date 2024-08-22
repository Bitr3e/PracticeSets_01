using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area, perimeter;
            char selected;

            Console.WriteLine("A - Compute Area");
            Console.WriteLine("P - Compute Perimeter");
            Console.WriteLine("X - Exit");

            Console.WriteLine("Enter your choice (A/P/X): ");
            selected = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (selected)
            {
                case 'A':
                    Console.WriteLine("Enter the radius of the circle: ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    area = Math.PI * Math.Pow(radius, 2);
                    Console.WriteLine($"The area of the circle is: {area}");
                    break;

                case 'P':
                Console.WriteLine("Enter the radius of the circle: ");
                radius = Convert.ToDouble(Console.ReadLine());
                perimeter = 2 * Math.PI * radius;
                Console.WriteLine($"The perimeter of the circle is: {perimeter}");
                break;

                case 'X':
                    Console.WriteLine("Exit the application");
                    break;
            
            }
        }
    }
}
