using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchholz_CourseProject_Part2
{
    public class Employee
    {
        //Employee Attributes via Supplied UML Diagram
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;


        //Constructing Information
        public Employee()
        {
            firstName = "N/A";
            lastName = "N/A";
            ssn = "N/A";
            hireDate = new DateTime();
        }

        public Employee(string firstName, string lastName, string ssn, DateTime hireDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hireDate = hireDate;
        }

        //Set-Up ToString and CalculatePay
        public override string ToString()
        {
            return "firstname=" + firstName
                + ", lastname=" + lastName
                + ", ssn=" + ssn
                + ", hireDate=" + hireDate.ToShortDateString();
        }

        public double CalculatePay()
        {
            return 0;
        }

        //Setting Up Get, Set, and Return values.
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }
        public DateTime HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
    }
}
