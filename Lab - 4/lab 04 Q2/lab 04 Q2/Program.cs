using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_04_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter the distance in kilometers: ");
                double km = double.Parse(Console.ReadLine());

                ConvertValues converter = new ConvertValues();
                converter.KilometerToMeter(km);

                Console.ReadLine();
            }
        }

        class ConvertValues
        {
            public void KilometerToMeter(double kM)
            {
                double m = kM * 1000;
                Console.WriteLine($"{kM} kilometers is equal to {m} meters.");
            }
        }

    }
}