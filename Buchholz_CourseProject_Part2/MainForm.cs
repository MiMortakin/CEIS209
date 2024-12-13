using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Buchholz_CourseProject_Part2
{
    public partial class MainForm : Form
    {
        //class level references
        private const string FILENAME = "Employees.dat";

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

                Employee emp = null;
                if (frmInput.salaryEmployee.Checked)
                {
                    double salary = double.Parse(frmInput.SalaryBox.Text);
                    emp = new Salary(fName, lName, ssn, hireDate, benefits, salary);
                }
                else if (frmInput.hourlyEmployee.Checked)
                { 
                    double hourlyRate = double.Parse(frmInput.HRBox.Text);
                    double hoursWorked = double.Parse(frmInput.HWBox.Text);
                    emp = new Hourly(fName, lName, ssn, hireDate, benefits, hourlyRate, hoursWorked);
                }
                else
                {
                    MessageBox.Show("Please Select the Type of Employee (Salary or Hourly).");
                    return;
                }

                //Employee object added to Employee Listbox
                EmployeesListBox.Items.Add(emp);

                //Employee added to SaveFile
                WriteEmpsToFile();
            }
        }

        private void WriteEmpsToFile()
        {
            //Converting Listbox items into a Generic List
            List<Employee> empList = new List<Employee>();

            foreach (Employee emp in EmployeesListBox.Items)
            {
                empList.Add(emp);
            }

            //Opens a pipe to the file and creates a translator
            FileStream fs = new FileStream(FILENAME, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();

            //Writes the generic list to our file
            formatter.Serialize(fs, empList);

            //Closes the pipe
            fs.Close();
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
            //Checks if File exists
            if(File.Exists(FILENAME) && new FileInfo(FILENAME).Length > 0)
            {
                //Creates a pipe from the file and Creates the "translator"
                FileStream fs = new FileStream(FILENAME, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();

                //Reads all the Employee Objects from the File
                List<Employee> list = (List<Employee>)formatter.Deserialize(fs);

                //Closes the Pipe
                fs.Close();

                //Clears Listbox items and Copys the file's Employee objects into the ListBox
                EmployeesListBox.Items.Clear();
                foreach (Employee emp in list) 
                    EmployeesListBox.Items.Add(emp);
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in EmployeesListBox.Items)
            {
                string line1 = "Pay To: " + emp.FirstName + " " + emp.LastName;
                string line2 = "Amount of: " + emp.CalculatePay().ToString("C2");

                string output = "Paycheck:\n\n" + line1 + "\n" + line2;
                MessageBox.Show(output);
            }    
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

                //Checks if the emp is a salary or hourly object
                if (emp is Salary)
                {
                    updateForm.HRText.Visible = false;
                    updateForm.HRBox.Visible = false;
                    updateForm.HWText.Visible = false;
                    updateForm.HWBox.Visible = false;
                    updateForm.salaryText.Visible = true; //This one is shown
                    updateForm.SalaryBox.Visible = true; //This one is showm

                    //Marks the Salary radio button as checked
                    updateForm.salaryEmployee.Checked = true;

                    //Converts the Employee object into Salary object
                    Salary salary = (Salary)emp;

                    //Shows the Salary Attributes
                    updateForm.SalaryBox.Text = salary.AnnualSalary.ToString("F0");
                }
                else if (emp is Hourly)
                {
                    updateForm.salaryText.Visible = false; //Hidden
                    updateForm.SalaryBox.Visible = false; //Hidden
                    updateForm.HRText.Visible = true;
                    updateForm.HRBox.Visible = true;
                    updateForm.HWText.Visible = true;
                    updateForm.HWBox.Visible = true;

                    //Marks the Hourly radio button as checked
                    updateForm.hourlyEmployee.Checked = true;

                    //Converts the Employee object into Hourly object
                    Hourly hrly = (Hourly)emp;

                    //Shows the hourly attributes
                    updateForm.HRBox.Text = hrly.HourlyRate.ToString("F2");
                    updateForm.HWBox.Text = hrly.HoursWorked.ToString("F1");
                }
                else
                {
                    MessageBox.Show("Invalid Employee Type Found!");
                    return;
                }

                DialogResult result = updateForm.ShowDialog();

                //If Cancelled = Stop Method
                if (result == DialogResult.Cancel)
                    return; //This ends the method

                //Deletes the Slected Object
                int position = EmployeesListBox.SelectedIndex;
                EmployeesListBox.Items.RemoveAt(position);

                //Creates New Employee with the Updated Information
                Employee newEmp = null;
                string fName = updateForm.firstNameText.Text;
                string lName = updateForm.lastNameText.Text;
                string ssn = updateForm.ssnText.Text;
                DateTime hireDate = DateTime.Parse(updateForm.hireDateText.Text);
                string healthInsurance = updateForm.HealthBox.Text;
                int lifeInsurance = int.Parse(updateForm.LifeBox.Text);
                int vacation = int.Parse(updateForm.VacBox.Text);
                Benefits benefits = new Benefits(healthInsurance, lifeInsurance, vacation);

                if (updateForm.salaryEmployee.Checked)
                {
                    double salary = double.Parse(updateForm.SalaryBox.Text);
                    newEmp = new Salary(fName, lName, ssn, hireDate, benefits, salary);
                }
                else if (updateForm.hourlyEmployee.Checked)
                {
                    double hourlyRate = double.Parse(updateForm.HRBox.Text);
                    double hoursWorked = double.Parse(updateForm.HWBox.Text);
                    newEmp = new Hourly(fName, lName, ssn, hireDate, benefits, hourlyRate, hoursWorked);
                }
                else
                {
                    MessageBox.Show("Error \nInvalid Employee Type!");
                    return;
                }

                //Addes new Employee to the Employee Listbox
                EmployeesListBox.Items.Add(newEmp);
            }
        }
    }

}
