using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_06__Q6
{
    class CalculateValues
    {
        public void UserInput(int size)
        {
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
                array[i + 1] = 0;
            }

            // Print the array values.
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            // Get the array size from the user.
            Console.WriteLine("Enter the array size:");
            int size = Convert.ToInt32(Console.ReadLine());

            // Create an object of the CalculateValues class.
            CalculateValues calculateValues = new CalculateValues();

            // Call the UserInput() method.
            calculateValues.UserInput(size);
        }
    }
}
