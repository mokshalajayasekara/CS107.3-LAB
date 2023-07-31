using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the distance in kilometers: ");
            double km = double.Parse(Console.ReadLine());

            ConvertValues converter = new ConvertValues();
            double m = converter.KilometerToMeter(km);

            Console.WriteLine($"{km} kilometers is equal to {m} meters.");

            Console.ReadLine();
        }
    }

    class ConvertValues
    {
        public double KilometerToMeter(double kilometer)
        {
            return kilometer * 1000;
        }
    }
}

