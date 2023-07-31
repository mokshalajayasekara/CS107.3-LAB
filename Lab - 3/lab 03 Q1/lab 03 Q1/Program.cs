using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);

            bool isEven = (number % 2 == 0);

            if (isEven)
            {
                Console.WriteLine("The number is Even.");
            }
            else
            {
                Console.WriteLine("The number is Odd.");
            }
        }
    }
    
}
