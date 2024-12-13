using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buchholz_CourseProject_Part2
{
    [Serializable] //Marking Serializable
    public class Hourly : Employee
    {
        public double HourlyRate { get; set; }
        public double HoursWorked { get; set; }

        public Hourly(string firstName, string lastName, string ssn, DateTime hireDate, Benefits benefits, double hourlyRate, double hoursWorked)
            : base(firstName, lastName, ssn, hireDate, benefits)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override double CalculatePay()
        {
            return HourlyRate * HoursWorked; //Pay is based on hourly rate times hours worked
        }

        public override string ToString()
        {
            return base.ToString() + $", Hourly Rate: {HourlyRate:C2}, Hours Worked: {HoursWorked}";
        }
    }
}
