/* 
    Author: Derrick Burns
    Date: 9/10/2019
    Description: This program will display a student's grades
*/

using System;

namespace Deliverable2_ConditionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for input
            Console.WriteLine("Enter in the grade you expect to get in ISM4300: \n");

            // Use the try-catch block to validate user input
            try
            {   
                // This variable will gather the user input
                string input = Console.ReadLine();

                /*
                    This variable will be used to store grades
                    after the input variable is parsed to int
                */
                int grade = int.Parse(input);

                // Data validation
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("\nGrade input value must be between 0 and 100");
                    return;
                }

                // Create a space
                Console.Write("\n");

                // If statement to test where the grade input falls
                if ((98 <= grade) && (grade <= 100))
                {
                    Console.WriteLine("A+");
                }
                else if ((92 <= grade) && (grade <= 97))
                {
                    Console.WriteLine("A");
                }
                else if ((90 <= grade) && (grade <= 91))
                {
                    Console.WriteLine("A-");
                }
                else if ((88 <= grade) && (grade <= 89))
                {
                    Console.WriteLine("B+");
                }
                else if ((82 <= grade) && (grade <= 87))
                {
                    Console.WriteLine("B");
                }
                else if ((80 <= grade) && (grade <= 81))
                {
                    Console.WriteLine("B-");
                }
                else if ((78 <= grade) && (grade <= 79))
                {
                    Console.WriteLine("C+");
                }
                else if ((72 <= grade) && (grade <= 77))
                {
                    Console.WriteLine("C");
                }
                else if ((70 <= grade) && (grade <= 71))
                {
                    Console.WriteLine("C-");
                }
                else if ((68 <= grade) && (grade <= 69))
                {
                    Console.WriteLine("D+");
                }
                else if ((62 <= grade) && (grade <= 67))
                {
                    Console.WriteLine("D");
                }
                else if ((60 <= grade) && (grade <= 61))
                {
                    Console.WriteLine("D-");
                }
                else
                {
                    Console.WriteLine("F");
                }
            } // End of try
            catch
            {
                Console.WriteLine("\nPlease use an integer data type for your projected grades");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            }
        }
    }
}
