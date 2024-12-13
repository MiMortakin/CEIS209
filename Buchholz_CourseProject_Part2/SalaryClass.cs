using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchholz_CourseProject_Part2
{
    [Serializable] //Marking Serializable
    public class Salary : Employee
    {
       public double AnnualSalary { get; set; }

    public Salary(string firstName, string lastName, string ssn, DateTime hireDate, Benefits benefits, double annualSalary)
            : base(firstName, lastName, ssn, hireDate, benefits)
        {
            AnnualSalary = annualSalary;
        }

        public override double CalculatePay()
        {
            return AnnualSalary / 26.0; //Bi-Weekly Pay
        }

        public override string ToString()
        {
            return base.ToString() + $", Annual Salary: {AnnualSalary:C2}";
        }

    }
}
