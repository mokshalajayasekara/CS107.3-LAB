using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;

            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double area = pi * radius * radius;

            Console.WriteLine("The area of the circle is: " + area);

            Console.ReadLine();
        }
    }
}
