using System;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first employee object
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.FirstName = "John";
            emp1.LastName = "Smith";

            // Create second employee object
            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.FirstName = "Jane";
            emp2.LastName = "Doe";

            // Compare both employees using overloaded == operator
            bool areEqual = emp1 == emp2;

            // Display the result of the comparison
            Console.WriteLine("Are the two employees equal? " + areEqual);

            // Also test the != operator
            Console.WriteLine("Are the two employees different? " + (emp1 != emp2));

            Console.ReadLine(); // Wait for user input before closing
        }
    }
}
