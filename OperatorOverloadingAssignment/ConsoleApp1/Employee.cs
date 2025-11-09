using System;

namespace OperatorOverloadingAssignment
{
    public class Employee
    {
        // Property for employee ID
        public int Id { get; set; }

        // Property for employee first name
        public string FirstName { get; set; }

        // Property for employee last name
        public string LastName { get; set; }

        // Overload the == operator to compare employees by Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check for null before comparing
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overload the != operator (must come in pair with ==)
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        // Override Equals to avoid compiler warning
        public override bool Equals(object obj)
        {
            if (obj is Employee other)
                return this.Id == other.Id;
            return false;
        }

        // Override GetHashCode when Equals is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
