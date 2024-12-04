using System;
using System.IO;
using System.Windows.Forms;

namespace Buchholz_CourseProject_Part2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ReadEmpsFromFile();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Add Employee to EmployeeListBox
            InputForm frmInput = new InputForm();

            using (frmInput)
            {
                DialogResult result = frmInput.ShowDialog();

                //If input form was cancelled
                if (result == DialogResult.Cancel)
                    return; //Ends the menthod due to cancelled input

                //Get the User's Input and Create an Employee Object
                string fName = frmInput.firstNameText.Text;
                string lName = frmInput.lastNameText.Text;
                string ssn = frmInput.ssnText.Text;
                string date = frmInput.hireDateText.Text;
                DateTime hireDate = DateTime.Parse(date);
                string healthIns = frmInput.HealthBox.Text;
                int lifeIns = int.Parse(frmInput.LifeBox.Text);
                int vacation = Int32.Parse(frmInput.VacBox.Text);

                Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
                Employee emp = new Employee(fName, lName, ssn, hireDate, benefits);

                //Adds the Employee object to Employee ListBox
                EmployeesListBox.Items.Add(emp);

                //Employee added to SaveFile
                WriteEmpsToFile();
            }
        }

        private void WriteEmpsToFile()
        {
            string filename = "Employees.csv";

            StreamWriter sw = new StreamWriter(filename, false);

            foreach (Employee emp in EmployeesListBox.Items)
            {
                sw.WriteLine(emp.FirstName + ',' 
                    + emp.LastName + ','
                    + emp.SSN + ','
                    + emp.HireDate.ToShortDateString() + ','
                    + emp.BenefitsEmp.HealthInsurance + ','
                    + emp.BenefitsEmp.LifeInsurance + ','
                    + emp.BenefitsEmp.VacationDays);
            }
            sw.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Remove Selected Employee from EmployeeListBox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if (itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);

                //Updates File After Removing Employee
                WriteEmpsToFile();
            }
            else
            {
                MessageBox.Show("Please Select an Employee to Remove.");
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            ReadEmpsFromFile();
            MessageBox.Show("Displaying All Employees...");
        }

        private void ReadEmpsFromFile()
        {
            EmployeesListBox.Items.Clear();

            string filename = "Employees.csv";
            StreamReader sr = new StreamReader(filename);

            while ( sr.Peek() != -1 )
            {
                string line = sr.ReadLine();
                string[] parts = line.Split(',');
                string firstName = parts[0];
                string lastName = parts[1];
                string ssn = parts[2];
                DateTime hireDate = DateTime.Parse(parts[3]);
                string healthIns = parts[4];
                int lifeIns = int.Parse(parts[5]);
                int vacation = Int32.Parse(parts[6]);

                //Employee Object and add to Listbox
                Benefits benefits = new Benefits(healthIns, lifeIns, vacation);
                Employee emp = new Employee(firstName, lastName, ssn, hireDate, benefits);
                EmployeesListBox.Items.Add(emp);
            }

            sr.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing All Employee Paychecks...");
        }

        private void EmployeesListBox_DoubleClick(object sender, EventArgs e)
        {
            Employee emp = (Employee)EmployeesListBox.SelectedItem;

            if (emp != null)
            {
                InputForm updateForm = new InputForm();

                updateForm.Text = "Update Employee Information";
                updateForm.submitButton.Text = "Update";
                updateForm.StartPosition = FormStartPosition.CenterParent;
                updateForm.firstNameText.Text = emp.FirstName;
                updateForm.lastNameText.Text = emp.LastName;
                updateForm.ssnText.Text = emp.SSN;
                updateForm.hireDateText.Text = emp.HireDate.ToShortDateString();
                updateForm.HealthBox.Text = emp.BenefitsEmp.HealthInsurance;
                updateForm.LifeBox.Text = emp.BenefitsEmp.LifeInsurance.ToString();
                updateForm.VacBox.Text = emp.BenefitsEmp.VacationDays.ToString();
                DialogResult result = updateForm.ShowDialog();

                //If Cancelled = Stop Method
                if (result == DialogResult.Cancel)
                    return; //This ends the method

                //Deletes the Slected Object
                int position = EmployeesListBox.SelectedIndex;
                EmployeesListBox.Items.RemoveAt(position);

                //Creates New Employee with the Updated Information
                Employee newEmp = new Employee();
                newEmp.FirstName = updateForm.firstNameText.Text;
                newEmp.LastName = updateForm.lastNameText.Text;
                newEmp.SSN = updateForm.ssnText.Text;
                newEmp.HireDate = DateTime.Parse(updateForm.hireDateText.Text);
                newEmp.BenefitsEmp.HealthInsurance = updateForm.HealthBox.Text;
                newEmp.BenefitsEmp.LifeInsurance = int.Parse(updateForm.LifeBox.Text);
                newEmp.BenefitsEmp.VacationDays = int.Parse(updateForm.VacBox.Text);

                //Adds the new Employee to the ListBox
                EmployeesListBox.Items.Add(newEmp);
            }

        }
    }

}
