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
    }
}
