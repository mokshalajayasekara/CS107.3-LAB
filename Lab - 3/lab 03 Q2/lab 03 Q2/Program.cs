using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiouAEIOU";


            Console.WriteLine("Enter a string: ");
            string stringInput = Console.ReadLine();


            int vowelCount = 0;

            string lowercaseString = stringInput.ToLower();

            for (int i = 0; i < lowercaseString.Length; i++)
            {
                if (vowels.Contains(lowercaseString[i]))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("The number of vowels in the string is: " + vowelCount);
        }
    }
}
