using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine("The sum of the two numbers is: " + sum);

            Console.ReadLine();
        }
    }
}
