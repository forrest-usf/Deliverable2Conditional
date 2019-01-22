/*
    Author: Matthew Bredahl
    Date: 01/20/2019
    Comments: This C# Console application code demonstrates the use of
              conditional statements after getting input from users. 
*/

using System;

namespace Deliverable2Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompts user for input and sends it to a string variable
            Console.Write("Type in the grade you expect to get in ISM 4300 (as an integer): ");

            try
            {
                string input = Console.ReadLine();

                //Converts string input to integer variable
                int grade = int.Parse(input);

                //Tests to see if the user put in a value greater than 100 - results in invalid input
                if (grade > 100)
                {
                    Console.WriteLine("Invalid input, you can't get higher than a 100 in this class.");
                }//End of if statement

                //Tests to see if the user put in a value between 98 & 100 - results in an A+
                else if (grade >= 98 && grade <= 100)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an A+");
                }//End if statement

                //Tests to see if the user put in a value between 92 & 97 - results in an A
                else if (grade >= 92 && grade <= 97)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an A");
                }//End if statement

                //Tests to see if the user put in a value between 90 & 91 - results in an A-
                else if (grade >= 90 && grade <= 91)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an A-");
                }//End if statement

                //Tests to see if the user put in a value between 88 & 89 - results in a B+
                else if (grade >= 88 && grade <= 89)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an B+");
                }//End if statement

                //Tests to see if the user put in a value between 82 & 87 - results in a B
                else if (grade >= 82 && grade <= 87)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an B");
                }//End if statement

                //Tests to see if the user put in a value between 80 & 81 - results in a B-
                else if (grade >= 80 && grade <= 81)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an B-");
                }//End if statement

                //Tests to see if the user put in a value between 78 & 79 - results in a C+
                else if (grade >= 78 && grade <= 79)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an C+");
                }//End if statement

                //Tests to see if the user put in a value between 88 & 89 - results in a C
                else if (grade >= 72 && grade <= 77)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an C");
                }//End if statement

                //Tests to see if the user put in a value between 70 & 71 - results in a C-
                else if (grade >= 70 && grade <= 71)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an C-");
                }//End if statement

                //Tests to see if the user put in a value between 68 & 69 - results in a D+
                else if (grade >= 68 && grade <= 69)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an D+");
                }//End if statement

                //Tests to see if the user put in a value between 62 & 67 - results in a D
                else if (grade >= 62 && grade <= 67)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an D");
                }//End if statement

                //Tests to see if the user put in a value between 60 & 61 - results in a D-
                else if (grade >= 60 && grade <= 61)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an D-");
                }//End if statement

                //Tests to see if the user put in a value less than 60 - results in an F
                else if (grade <= 60)
                {
                    Console.WriteLine("Per the Syllabus, you will get the letter grade of an F");
                }//End if statement

                //Catches any user input that isn't covered in the above logic tests
                else
                {
                    Console.WriteLine("There were issues with your input, please try again");
                }//End else statement
            }//End try
            catch
            {
                Console.WriteLine("An error has occured");
            }//End catch
        }//End Main method
    }//End Program class
}//End namespace
