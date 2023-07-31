using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_Q3
{
    class CalculateValues
    {
        public int Addition(int no1, int no2)
        {
            return no1 + no2;
        }

        public int Subtraction(int no1, int no2)
        {
            return no1 - no2;
        }

        public int Multiplication(int no1, int no2)
        {
            return no1 * no2;
        }

        public int Division(int no1, int no2)
        {
            return no1 / no2;
        }
    }
    class MainClass
    {
        static void Main(string[] args)
        {
            CalculateValues calculateValues = new CalculateValues();

            int choice;
            int no1;
            int no2;

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter Your choice:");
            choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter two numbers");
            Console.Write("Enter number 1:");
            no1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number 2:");
            no2 = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The answer is: " + calculateValues.Addition(no1, no2));
                    break;
                case 2:
                    Console.WriteLine("The answer is: " + calculateValues.Subtraction(no1, no2));
                    break;
                case 3:
                    Console.WriteLine("The answer is: " + calculateValues.Multiplication(no1, no2));
                    break;
                case 4:
                    Console.WriteLine("The answer is: " + calculateValues.Division(no1, no2));
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}