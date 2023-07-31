using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an upper limit: ");
            string upperLimitStr = Console.ReadLine();
            int upperLimit = Convert.ToInt32(upperLimitStr);


            int sum = 0;


            for (int i = 1; i <= upperLimit; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("The sum of all the odd numbers from 1 to {0} is {1}.", upperLimit, sum);
        }
    }
}
