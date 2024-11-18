using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Add Employee to EmployeeListBox
            EmployeesListBox.Items.Add("New Employee");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            //Remove Selected Employee from EmployeeListBox
            int itemNumber = EmployeesListBox.SelectedIndex;

            if(itemNumber > -1)
            {
                EmployeesListBox.Items.RemoveAt(itemNumber);
            }
            else
            {
                MessageBox.Show("Please Select an Employee to Remove.");
            }
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Displaying All Employees...");
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing All Employee Paychecks...");
        }
    }
}
