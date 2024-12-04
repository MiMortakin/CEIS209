using System;

namespace Buchholz_CourseProject_Part2
{
    public class Employee
    {
        // Employee Attributes via Supplied UML Diagram
        private string firstName;
        private string lastName;
        private string ssn;
        private DateTime hireDate;
        private Benefits benefits; // From BenefitsClass

        // Default Constructor
        public Employee()
        {
            firstName = "N/A";
            lastName = "N/A";
            ssn = "N/A";
            hireDate = new DateTime();
            benefits = new Benefits(); // Initialize default Benefits object
        }

        // Parameterized Constructor
        public Employee(string firstName, string lastName, string ssn, DateTime hireDate, Benefits benefits)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.ssn = ssn;
            this.hireDate = hireDate;
            this.benefits = benefits; // Assign Benefits object
        }

        // ToString and CalculatePay
        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name: {lastName} | SSN: {ssn} | Hire Date: {hireDate.ToShortDateString()} | Benefits: {benefits}";
        }

        public double CalculatePay()
        {
            return 0;
        }

        // Getters and Setters
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

        public Benefits BenefitsEmp
        {
            get { return benefits; }
            set { benefits = value; }
        }
    }
}
