using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());


            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;


            Console.WriteLine("Area of the circle: " + area.ToString("0.00"));
            Console.WriteLine("Circumference of the circle: " + circumference.ToString("0.00"));

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
