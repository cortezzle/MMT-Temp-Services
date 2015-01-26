using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CortezFBLA
{
   public class Employee
    {
       //This class makes an object from employee data to represent an employee.
        public string empID, first, last, name, email, home, cell, address, address2, theCity, theState, zip, company;
        public List<Evaluation> employeeEvaluations = new List<Evaluation>();

        public Employee(string EmployeeIdentifier, string firstName, string lastName, string emailAddress, string homePhone, string cellPhone,
            string streetAddress, string streetAddress2, string city, string state, string zipCode)
        {
            empID = EmployeeIdentifier;
            first = firstName;
            last = lastName;
            name = firstName + " " + lastName;
            email = emailAddress;
            home = homePhone;
            cell = cellPhone;
            address = streetAddress;
            address2 = streetAddress2;
            theCity = city;
            theState = state;
            zip = zipCode;
            
        }

    }
}
