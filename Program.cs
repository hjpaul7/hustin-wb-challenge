using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D4_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare and initialize variables. One of type int, one of type string, and one of type DateTime.

            int myAge = 29;
            string ageString = "My age is";
            string birthDateString = "I was born on";
            DateTime dateOfBirth = new DateTime(1991, 3, 11);

            Console.WriteLine($"{ageString} {myAge} {birthDateString} {dateOfBirth}");

            // Create a method that subtracts two numbers and returns the value.

            int numOne = 5;
            int numTwo = 3;

            Console.WriteLine(numOne - numTwo);

            // Create a method that takes two strings from the user and outputs a string.

            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine($"So your full name is {firstName} {lastName}?");


            // Write a switch case that asks the user if they are wearing clothes.

            Console.WriteLine("Are you wearing clothes?");
            string userInput = Console.ReadLine();


            switch (userInput)
            {
                case "yes":
                    Console.WriteLine("That's good!");
                    break;

                case "no":
                    Console.WriteLine("Get some clothes");
                    break;
            }

            // Write an if else statement that uses a boolean to check if the user is happy.You can start off with something like: bool happy = true;

            bool isHappy = true;

            if (isHappy)
            {
                Console.WriteLine("you're happy");
            }
            else
            {
                Console.WriteLine("you're unhappy");
            }

            Console.WriteLine("Are you happy?");
            bool happy = true;
            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine(happy);
            }
            else
            {
                Console.WriteLine("You're unhappy");
            }
                


            // Write an if, else if, else that asks the user how much money they make a year.Check ranges between 1,000 - 10,000,  11,000 - 50,000, and 51,000 - 100,000.Output to the test runner based on each salary range.Have a else statement to prepare for the user not giving their salary range or out of the ranges we are checking.
            Console.WriteLine("How much money do you make in a year?");
            string earningString = Console.ReadLine();
            decimal earnings = decimal.Parse(earningString);

            if (earnings >= 1000 && earnings <= 10000)
            {
                Console.WriteLine("Low salary");
            }
            else if (earnings >= 11000 && earnings <= 50000)
            {
                Console.WriteLine("Moderate ammount");
            }
            else if (earnings >= 51000 && earnings <= 100000)
            {
                Console.WriteLine("That's a lot");
            }
            else
            {
                Console.WriteLine("Nothing to say");
            }

            Console.ReadLine();
        }
    }
}
