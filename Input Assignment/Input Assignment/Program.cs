using System;
using System.IO;   // lets us work with files

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for a number
        Console.WriteLine("Please enter a number:");

        // Read what the user types
        string userInput = Console.ReadLine();

        // The file where we will save the number
        string filePath = "log.txt";

        // Write the number to the text file
        // File.WriteAllText creates the file if it does not exist
        File.WriteAllText(filePath, userInput);

        // Read the saved content from the file
        string fileContent = File.ReadAllText(filePath);

        // Show the content to the user
        Console.WriteLine("You entered (from file): " + fileContent);

        // Keep console open
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
