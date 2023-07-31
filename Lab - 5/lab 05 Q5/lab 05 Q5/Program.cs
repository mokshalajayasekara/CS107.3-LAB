using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_Q5
{
    public class ArrayOperations
    {
        public static int FindMinimum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int FindMaximum(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static double FindAverage(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] reversed = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                reversed[i] = arr[arr.Length - 1 - i];
            }
            return reversed;
        }
    }
    public class Program
    {
        public static void Main()
        {
            int[] array = new int[10];

            Console.WriteLine("Enter 10 integers to fill the array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int minimum = ArrayOperations.FindMinimum(array);
            int maximum = ArrayOperations.FindMaximum(array);
            double average = ArrayOperations.FindAverage(array);
            int[] reversedArray = ArrayOperations.ReverseArray(array);

            Console.WriteLine("Minimum value: " + minimum);
            Console.WriteLine("Maximum value: " + maximum);
            Console.WriteLine("Average value: " + average);
            Console.WriteLine("Reversed order of values:");
            foreach (int num in reversedArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}
