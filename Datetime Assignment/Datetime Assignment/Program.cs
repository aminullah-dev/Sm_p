using System;   // Allows use of DateTime and Console

namespace DatetimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time
            Console.WriteLine("Current Date and Time:");
            Console.WriteLine(DateTime.Now);

            // Ask the user to enter a number
            Console.WriteLine("Enter a number of hours:");
            int hours = Convert.ToInt32(Console.ReadLine());  // Convert user input to an integer

            // Add the entered hours to the current time
            DateTime futureTime = DateTime.Now.AddHours(hours);

            // Show the future time on the screen
            Console.WriteLine("In " + hours + " hours, it will be:");
            Console.WriteLine(futureTime);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
