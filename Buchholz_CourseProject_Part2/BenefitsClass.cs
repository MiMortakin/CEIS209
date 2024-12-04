namespace Buchholz_CourseProject_Part2
{
    public class Benefits
    {
        //Attributes
        private string healthInsurance;
        private int vacationDays;
        private double lifeInsurance;

        //Constructor
        public Benefits()
        {
            healthInsurance = "None";
            lifeInsurance = 0;
            vacationDays = 0;
        }

        public Benefits(string healthInsurance, double lifeInsurance, int vacationDays)
        {
            this.healthInsurance = healthInsurance;
            this.lifeInsurance = lifeInsurance;
            this.vacationDays = vacationDays;
        }

        //Encapsulation
        public string HealthInsurance
        {
            get { return healthInsurance; }
            set { healthInsurance = value; }
        }

        public double LifeInsurance
        {
            get { return lifeInsurance; }
            set { lifeInsurance = value; }
        }

        public int VacationDays
        {
            get { return vacationDays; }
            set { vacationDays = value; }
        }

        //Override for Display
        public override string ToString()
        {
            return $" Health Insurance: {healthInsurance}, Life Insurance: {lifeInsurance}, Vacation Days: {vacationDays}";
        }
    }
}
