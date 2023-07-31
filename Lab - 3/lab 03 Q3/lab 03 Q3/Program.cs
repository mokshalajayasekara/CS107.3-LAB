using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);


            int sum = 0;


            while (number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number = number / 10;
            }
            Console.WriteLine("The sum of the digits is: " + sum);
        }
    }
}
