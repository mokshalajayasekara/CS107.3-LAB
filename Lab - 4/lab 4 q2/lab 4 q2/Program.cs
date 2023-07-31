using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_q2
{
    class FindValues
    {
        public static double FindArea(double r)
        {
            return Math.PI * r * r; //r=radious
        }

        // Method to find the circumference of a circle
        public static double FindCircumference(double r)
        {
            return 2 * Math.PI * r;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle:");
            double r = double.Parse(Console.ReadLine());

            double area = FindValues.FindArea(r);
            double circumference = FindValues.FindCircumference(r);

            Console.WriteLine($"Area of the circle: {area:F2}");
            Console.WriteLine($"Circumference of the circle: {circumference:F2}");

            Console.ReadLine();
        }
    }
}
