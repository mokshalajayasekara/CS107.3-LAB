using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            string firstNumberStr = Console.ReadLine();
            int firstNumber = Convert.ToInt32(firstNumberStr);

            Console.WriteLine("Enter the second number: ");
            string secondNumberStr = Console.ReadLine();
            int secondNumber = Convert.ToInt32(secondNumberStr);

            int sum = firstNumber + secondNumber;
            int difference = firstNumber - secondNumber;
            int product = firstNumber * secondNumber;
            float quotient = firstNumber / secondNumber;

            Console.WriteLine("The sum of the two numbers is: " + sum);
            Console.WriteLine("The difference of the two numbers is: " + difference);
            Console.WriteLine("The product of the two numbers is: " + product);
            Console.WriteLine("The quotient of the two numbers is: " + quotient);
        }
    }
}
