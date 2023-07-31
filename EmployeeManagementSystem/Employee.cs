using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Employee
    {
        // Class Attributes
        private int EmployeeID {get; set;}
        private string FirstName { get; set;}
        private string LastName { get; set;}
        private Address Address { get; set;}
        private string Email { get; set;}
        private string PhoneNumber { get; set;}
        private string Department { get; set;}
        private string Position { get; set;}
        private int Salary { get; set;}

        // Class Methods

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public string DisplayInfo()
        {
            string infoString = $"Employee: {EmployeeID}\nLast Name: {LastName}, First Name: {FirstName}\nDepartment: {Department}, Position: {.Position}, Salary: {Salary}" +
                $"\nAddress: {Address.PrintAddress}, Email: {Email}";
            return infoString;
        }
    }
}
