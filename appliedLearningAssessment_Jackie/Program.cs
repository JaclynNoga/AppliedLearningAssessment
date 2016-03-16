using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appliedLearningAssessment_Jackie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Jackie's Applied Learning Assessment!\n");

            //#1 A program that asks user for an integer and prints out
            //different outputs.

            //asks for user input
            Console.WriteLine("Please enter an integer: ");
            //saves input as an int
            int userInt = int.Parse(Console.ReadLine());
            if (userInt < 10)   //if user's integer is less than 10
            {
                Console.WriteLine("This number is too small.");
            }
            else if (userInt >= 10) //if user's integer is greater than or equal to 10
            {
                Console.WriteLine("This number is big enough");
            }
            Console.WriteLine("\n");    //separates Program #1 and #2 with 2 lines

            //#2 A program that has an array of 5 floats and prints the 
            //2nd value.

            //initializes a float array
            float[] someArray = { 3.1415f, 3.4f, 9.8f, 5.11f, 98.6f };
            //prints out second value
            Console.WriteLine(someArray[1]);
            Console.WriteLine("\n");    //separates Program #2 and #3


            //#3 A program that prints the array in #2

            foreach (float aFloat in someArray)     //loops through each value in array
            {
                Console.Write(aFloat + " ");    //prints each value in array and a space
            }
            Console.WriteLine("\n");    //separates Program #3 and #4

            //#4 A program that prints different things based on 
            //user's integer using a switch statement.

            //prompts user for an integer
            Console.WriteLine("Please enter an integer: ");
            //saves integer to an int
            int someInt = int.Parse(Console.ReadLine());
            switch (someInt)
            {
                case 1:
                    {
                        Console.WriteLine("Only one?");
                        break;
                    }
                case 100:
                    {
                        Console.WriteLine("100? That's a lot!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Input not recognized.");
                        break;
                    }
            }
        }
    }
}
