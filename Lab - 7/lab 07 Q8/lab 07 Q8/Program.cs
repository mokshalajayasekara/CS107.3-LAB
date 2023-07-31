using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_07_Q8
{
    class Animal
    {
        public void IAmAnimal()
        {
            Console.WriteLine("I am Animal");
        }
    }

    class Dog : Animal
    {
        public void IHaveFourLegs()
        {
            Console.WriteLine("I have four legs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.IAmAnimal();
            dog.IHaveFourLegs();
        }
    }
}
