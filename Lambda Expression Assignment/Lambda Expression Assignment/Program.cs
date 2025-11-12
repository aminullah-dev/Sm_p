using System;
using System.Collections.Generic;
using System.Linq; // Needed for lambda expressions and LINQ methods

namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee() { Id = 2, FirstName = "Mary", LastName = "Johnson" },
                new Employee() { Id = 3, FirstName = "Joe", LastName = "Brown" },
                new Employee() { Id = 4, FirstName = "Tom", LastName = "White" },
                new Employee() { Id = 5, FirstName = "Sara", LastName = "Black" },
                new Employee() { Id = 6, FirstName = "David", LastName = "Green" },
                new Employee() { Id = 7, FirstName = "Lisa", LastName = "Adams" },
                new Employee() { Id = 8, FirstName = "John", LastName = "Hill" },
                new Employee() { Id = 9, FirstName = "Betty", LastName = "King" },
                new Employee() { Id = 10, FirstName = "Paul", LastName = "Scott" }
            };

            // ==============================
            // Find all employees named "Joe" using a foreach loop
            // ==============================
            List<Employee> joeList1 = new List<Employee>(); // Empty list for "Joe"s

            foreach (Employee emp in employees) // Go through each employee
            {
                if (emp.FirstName == "Joe")     // Check if first name is "Joe"
                {
                    joeList1.Add(emp);          // Add to the new list
                }
            }

            // Print the result
            Console.WriteLine("Employees named Joe (using foreach):");
            foreach (Employee emp in joeList1)
            {
                Console.WriteLine(emp.FirstName + " " + emp.LastName);
            }

            // ==============================
            // Find all employees named "Joe" using a lambda expression
            // ==============================
            List<Employee> joeList2 = employees.Where(e => e.FirstName == "Joe").ToList();

            Console.WriteLine("\nEmployees named Joe (using lambda):");
            joeList2.ForEach(e => Console.WriteLine(e.FirstName + " " + e.LastName));

            // ==============================
            // Find all employees whose ID number is greater than 5
            // ==============================
            List<Employee> idGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            Console.WriteLine("\nEmployees with Id > 5:");
            idGreaterThan5.ForEach(e => Console.WriteLine(e.FirstName + " " + e.LastName));

            // Keep console open until the user presses a key
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
