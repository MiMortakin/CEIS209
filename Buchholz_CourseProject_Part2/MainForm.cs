using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                Employee emp = new Employee(fName, lName, ssn, hireDate);

                //Adds the Employee object to Employee ListBox
                EmployeesListBox.Items.Add(emp);

                //Employee added to SaveFile
                WriteEmpsToFile();
            }
        }

        private void WriteEmpsToFile()
        {
            string filename = "Employees.csv";

            StreamWriter sw = new StreamWriter(filename);

            foreach (Employee emp in EmployeesListBox.Items)
            {
                sw.WriteLine(emp.FirstName + ',' + emp.LastName + ',' + emp.SSN + ',' + emp.HireDate.ToShortDateString());
            }
            sw.Close();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Remove Selected Employee from EmployeeListBox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if(itemNumber > -1)
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

            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine();
                string[] parts = line.Split(',');
                string firstName = parts[0];
                string lastName = parts[1];
                string ssn = parts[2];
                DateTime hireDate = DateTime.Parse(parts[3]);
                Employee emp = new Employee(firstName, lastName, ssn, hireDate);
                EmployeesListBox.Items.Add(emp);
            }

            sr.Close();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing All Employee Paychecks...");
        }

        
    }
}
