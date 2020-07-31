using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4_Challenge
{
    class MethodClass
    {
        public void FullNameString()
        {
            // Create a method that takes two strings from the user and outputs a string.

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"So your full name is {firstName} {lastName}?");
        }

        public int Subtraction(int numOne, int numTwo)
        {
            // Create a method that subtracts two numbers and returns the value.
            int subtraction = numOne - numTwo;
            return subtraction;

        }
    }
}
