using System;
using System.Windows.Forms;

namespace Buchholz_CourseProject_Part2
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            salaryText.Visible = salaryEmployee.Checked;
            SalaryBox.Visible = salaryEmployee.Checked;
            HRText.Visible = hourlyEmployee.Checked;
            HRBox.Visible = hourlyEmployee.Checked;
            HWText.Visible = hourlyEmployee.Checked;
            HWBox.Visible = hourlyEmployee.Checked;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            salaryText.Visible = salaryEmployee.Checked;
            SalaryBox.Visible = salaryEmployee.Checked;
            HRText.Visible = hourlyEmployee.Checked;
            HRBox.Visible = hourlyEmployee.Checked;
            HWText.Visible = hourlyEmployee.Checked;
            HWBox.Visible = hourlyEmployee.Checked;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
