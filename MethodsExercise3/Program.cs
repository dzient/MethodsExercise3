using System;
using System.Collections.Generic;

//-----------------------------------------------------------------
//Iteration Statements
//
// Name: David Zientara
// Date: 7-4-2022
// Comments: Made changes to the program, per the instructions
//-----------------------------------------------------------------
namespace MethodsExercise3
{
    class Program
    {
        // PrintNumbers
        // Given a list of integers, print that list
        // PARAMS: List of integers
        // RETURNS: Nothing
        static void PrintNumbers(List<int> numbers)
        {
            foreach (int number in numbers)
                Console.WriteLine(number);
        }
        // PrintByThree
        // Given a list of integers from -1000 to 1000,
        // print integers from 3 to 999 by 3
        // PARAMS: List of integers
        // RETURNS: Nothing
        static void PrintByThree(List<int> numbers)
        {
            // Easier to reverse the list and do a foreach loop:
            numbers.Reverse();
            foreach (int number in numbers)
                if (number >= 3 && number <= 999 && (number%3)==0)
                    Console.WriteLine(number);

        }
        // AreEqual
        // Method reads in two integers;
        // prints whether they are equal or not
        // PARAMS: Nothing
        // RETURNS: Nothing
        static void AreEqual()
        {
            Console.WriteLine("Enter an integer: ");
            var line = Console.ReadLine();
            int a = int.Parse(line);
            Console.WriteLine("Enter another integer: ");
            line = Console.ReadLine();
            int b = int.Parse(line);
            if (a == b)
                Console.WriteLine("The integers are equal.");
            else
                Console.WriteLine("The integers are not equal.");
        }
        // EvenOrOdd
        // Given an integer, returns string
        // indicating whether it's even or odd
        // PARAMS: An integer
        // RETURNS: "even" if integer is even, "false" otherwise
        static string EvenOrOdd(int num)
        {
            if ((num % 2) == 0)
                return "even";

            return "odd";
         }
        // CanVote
        // Given an age, return bool indicating,
        // whether the person can vote
        // PARAMS: An integer
        // RETURNS: True if the age is greater than
        // or equal to the age, false otherwise
        static bool CanVote(int age)
        {
            // Declare a constant so we can change it
            const int VOTINGAGE = 18;
            if (age >= VOTINGAGE)
                return true;
            return false;
        }
        // WithinRange
        // Given a number, the minimum and maximum,
        // return true if the number is w/in range
        // PARAMS: Three integers: num, min and max
        // RETURNS: True if the # is >= min and <= max,
        // false otherwise
        static bool WithinRange(int num, int min, int max)
        {
            if (num >= min && num <= max)
                return true;
            return false;
        }
        // PrintMultTable
        // Given a number 
        // print the multiplication table for it
        // PARAMS: An integer
        // RETURNS: Nothing
        static void PrintMultTable(int num)
        {
            // Again we define a constant:
            const int MAX = 12;
            for (int i = 0; i <= MAX; i++)
                Console.WriteLine($"{i} * {num} = {i * num}");
           
        }
        static void Main(string[] args)
        {
            //Allocate a list and add integers to it
            //1000 to -1000
            var numbers = new List<int>();
            for (int i = 1000; i >= -1000; i--)
                numbers.Add(i);

            //Call methods to print the #s and print by three:
            PrintNumbers(numbers);
            PrintByThree(numbers);
            //Call a method to read in two #s and determine if they're equal
            AreEqual();
            var rand = new Random();
            //Read a random # and determine if it's even or odd
            var num = rand.Next(100);
            Console.WriteLine($"{num} is an {EvenOrOdd(num)} number.");
            bool res = false;
            int age = -1;
            //Read an age and find out if it's odd or even
            do
            {
                Console.WriteLine("Enter your age: ");
                var line = Console.ReadLine();
                res = int.TryParse(line, out age);
            } while (!res);
            if (CanVote(age))
                Console.WriteLine("You can vote.");
            else
                Console.WriteLine("You cannot vote.");
            //Read an integer and find out if it's w/in -10 to 10
            do
            {
                Console.WriteLine("Enter an integer: ");
                var line = Console.ReadLine();
                res = int.TryParse(line, out num);
            } while (!res);
            if (WithinRange(num,-10,10))
                Console.WriteLine("Number is within range -10 to 10");
            else
                Console.WriteLine("Number is not within range -10 to 10");
            //Read an integer from 1 to 12 and print the multiplication
            //table for it
            do
            {
                Console.WriteLine("Enter an number between 1 and 12: ");
                var line = Console.ReadLine();
                res = int.TryParse(line, out num);
            } while (!WithinRange(num,1,12) || !res);

            PrintMultTable(num);


        }
    }
}
