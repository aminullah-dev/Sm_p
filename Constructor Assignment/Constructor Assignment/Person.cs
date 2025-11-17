using System;

namespace ConstructorAssignment
{
    public class Person
    {
        // const variable - cannot change once set
        public const string Country = "Canada";

        // Class properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor with one parameter
        public Person(string name)
        {
            // Call the second constructor using a default age of 0
            Name = name;
            Age = 0;
        }

        // Constructor with two parameters
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
