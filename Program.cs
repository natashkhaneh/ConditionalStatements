using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks user to input their grade
            Console.WriteLine("Please enter your expected grade...");

            try
            {
                // Reads the user's input
                string input = Console.ReadLine();

                // Parses the user's input to an integer, grade
                int grade = int.Parse(input);

                // Displays message for if grade is 59 or below (F)
                if ((grade >= 0) && (grade <= 59))
                {
                    Console.WriteLine("Your expected grade is an F.");
                    Console.WriteLine("Press any key to exit the program.");

                    //Waits for the user to press a key  before exiting program.
                    Console.ReadKey(true);
                }

                //Displays message for if grade is 60-69 (D)
                else if ((grade >= 60) && (grade <= 69))
                {
                    Console.WriteLine("Your expected grade is a D.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                // Displays message for if grade is 70-79 (C)
                else if ((grade >= 70) && (grade <= 79))
                {
                    Console.WriteLine("Your expected grade is a C.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                //Displays message for if grade is 80-89 (B)
                else if ((grade >= 80) && (grade <= 89))
                {
                    Console.WriteLine("Your expected grade is a B.");
                    Console.WriteLine("Press any key to exit the program.");
                    Console.ReadKey(true);
                }

                //Displays message for if grade is above 90 (A)
                else if (grade >= 90)
                {
                    Console.WriteLine("Your expected grade is an A.");
                    Console.WriteLine("Press any key to exit the program.");

                    Console.ReadKey(true);
                }
                // End of try statement
            }

            // Displays a message if user input is not valid.
            catch
            {
                Console.WriteLine("Invalid input! Please enter a valid grade greater than zero! ");
                Console.WriteLine("Press any key to exit the program and try again.");
                Console.ReadKey(true);
            }
            //End of catch
        }
    }
}