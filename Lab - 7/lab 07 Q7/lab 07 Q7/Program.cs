using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07_Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the size of the arrays from the user.
            Console.WriteLine("Enter the size of the arrays: ");
            int size = int.Parse(Console.ReadLine());

            // Declare two arrays of size `size`.
            int[] array1 = new int[size];
            int[] array2 = new int[size];

            // Fill the arrays with user input.
            Console.WriteLine("Enter the elements of array1: ");
            for (int i = 0; i < size; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements of array2: ");
            for (int i = 0; i < size; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            // Calculate the scalar sum.
            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i] + array2[i];
            }

            // Calculate the vector sum.
            int[] vectorSum = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorSum[i] = array1[i] + array2[i];
            }

            // Calculate the vector product.
            int[] vectorProduct = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorProduct[i] = array1[i] * array2[i];
            }

            // Calculate the scalar product.
            int scalarProduct = 0;
            for (int i = 0; i < size; i++)
            {
                scalarProduct += vectorProduct[i];
            }

            // Display the results.
            Console.WriteLine("Scalar sum: " + scalarSum);
            Console.WriteLine("Vector sum: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(vectorSum[i]);
            }
            Console.WriteLine("Vector product: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(vectorProduct[i]);
            }
            Console.WriteLine("Scalar product: " + scalarProduct);
        }
    }
}

