using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userInputs = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number: ");
                string numberStr = Console.ReadLine();
                int number = Convert.ToInt32(numberStr);
                userInputs[i] = number;
            }

            for (int i = 0; i < 10; i++)
            {
                bool isEven = (userInputs[i] % 2 == 0);
                if (isEven)
                {
                    Console.WriteLine("The number {0} is even.", userInputs[i]);
                }
                else
                {
                    Console.WriteLine("The number {0} is odd.", userInputs[i]);
                }
            }
        }
