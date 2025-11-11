using System;

namespace ParsingEnumsAssignment
{
    // Define an enum that represents the days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to type the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Read user input as text
            string userInput = Console.ReadLine();

            try
            {
                // Try to convert the text into our enum type (case-insensitive)
                DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // If parse is successful, print the parsed value
                Console.WriteLine("You entered: " + day);
            }
            catch
            {
                // If parsing fails (invalid text), show a friendly message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep console open until user presses a key
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
