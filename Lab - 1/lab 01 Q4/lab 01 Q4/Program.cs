using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the salary: ");
            string salaryStr = Console.ReadLine();
            double salary = Convert.ToDouble(salaryStr);

            Console.WriteLine("Enter the tax rate (in percentage): ");
            string taxRateStr = Console.ReadLine();
            double taxRate = Convert.ToDouble(taxRateStr) / 100;

            double tax = salary * taxRate;

            double salaryAfterTax = salary - tax;

            Console.WriteLine("The salary after the tax is: " + salaryAfterTax);
        }
    }
}
