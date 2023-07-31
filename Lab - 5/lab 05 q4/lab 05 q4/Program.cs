using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_q4
{
    public class MyClass
    {
        private void sayHello()
        {
            Console.WriteLine("Hello, world!");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create an object of the MyClass class.
            var myClass = new MyClass();
            // Try to access the sayHello() method.
            //myClass.sayHello(); // This will not compile.
        }
    }
    public class MyClass
    {
        public void sayHellow()
        {
            Console.WriteLine("Hello, world!");
        }
    }
    public class Programme
    {
        public static void Main(string[] args)
        {
            // Create an object of the MyClass class.
            var myClass = new MyClass();
            // Access the sayHello() method.
            myClass.sayHellow();
        }
    }
}

