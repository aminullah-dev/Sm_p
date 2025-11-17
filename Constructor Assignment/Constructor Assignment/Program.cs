using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object using the constructor with one parameter
            Person person1 = new Person("Amin");

            // Create an object using the constructor with two parameters
            Person person2 = new Person("Amin", 25);

            // Use 'var' keyword to let C# decide the type automatically
            var message = "Object created successfully";

            // Print output
            Console.WriteLine(message);
            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name + " is " + person2.Age + " years old");

            Console.ReadLine();
        }
    }
}
