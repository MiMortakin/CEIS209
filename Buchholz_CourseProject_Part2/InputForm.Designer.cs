namespace Buchholz_CourseProject_Part2
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ssnLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.ssnText = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.hireDateText = new System.Windows.Forms.TextBox();
            this.GroupBenefitsBox = new System.Windows.Forms.GroupBox();
            this.VacBox = new System.Windows.Forms.TextBox();
            this.LifeBox = new System.Windows.Forms.TextBox();
            this.HealthBox = new System.Windows.Forms.TextBox();
            this.VacationText = new System.Windows.Forms.Label();
            this.LifeText = new System.Windows.Forms.Label();
            this.HealthText = new System.Windows.Forms.Label();
            this.EmployeeTypeGroup = new System.Windows.Forms.GroupBox();
            this.SalaryBox = new System.Windows.Forms.TextBox();
            this.salaryText = new System.Windows.Forms.Label();
            this.HWBox = new System.Windows.Forms.TextBox();
            this.HRBox = new System.Windows.Forms.TextBox();
            this.HWText = new System.Windows.Forms.Label();
            this.HRText = new System.Windows.Forms.Label();
            this.salaryEmployee = new System.Windows.Forms.RadioButton();
            this.hourlyEmployee = new System.Windows.Forms.RadioButton();
            this.EmployeeInfoGroup = new System.Windows.Forms.GroupBox();
            this.GroupBenefitsBox.SuspendLayout();
            this.EmployeeTypeGroup.SuspendLayout();
            this.EmployeeInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(27, 31);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 24);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(27, 66);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(104, 24);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(27, 101);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(58, 24);
            this.ssnLabel.TabIndex = 2;
            this.ssnLabel.Text = "SSN: ";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(190, 28);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(290, 29);
            this.firstNameText.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(190, 63);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(290, 29);
            this.lastNameText.TabIndex = 1;
            // 
            // ssnText
            // 
            this.ssnText.Location = new System.Drawing.Point(190, 98);
            this.ssnText.Name = "ssnText";
            this.ssnText.Size = new System.Drawing.Size(290, 29);
            this.ssnText.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitButton.Location = new System.Drawing.Point(65, 516);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(132, 37);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightCoral;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(282, 516);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 37);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hire Date:";
            // 
            // hireDateText
            // 
            this.hireDateText.Location = new System.Drawing.Point(190, 133);
            this.hireDateText.Name = "hireDateText";
            this.hireDateText.Size = new System.Drawing.Size(290, 29);
            this.hireDateText.TabIndex = 3;
            // 
            // GroupBenefitsBox
            // 
            this.GroupBenefitsBox.Controls.Add(this.VacBox);
            this.GroupBenefitsBox.Controls.Add(this.LifeBox);
            this.GroupBenefitsBox.Controls.Add(this.HealthBox);
            this.GroupBenefitsBox.Controls.Add(this.VacationText);
            this.GroupBenefitsBox.Controls.Add(this.LifeText);
            this.GroupBenefitsBox.Controls.Add(this.HealthText);
            this.GroupBenefitsBox.Location = new System.Drawing.Point(12, 345);
            this.GroupBenefitsBox.Name = "GroupBenefitsBox";
            this.GroupBenefitsBox.Size = new System.Drawing.Size(499, 134);
            this.GroupBenefitsBox.TabIndex = 2;
            this.GroupBenefitsBox.TabStop = false;
            this.GroupBenefitsBox.Text = "Benefits";
            // 
            // VacBox
            // 
            this.VacBox.Location = new System.Drawing.Point(190, 90);
            this.VacBox.Name = "VacBox";
            this.VacBox.Size = new System.Drawing.Size(290, 29);
            this.VacBox.TabIndex = 2;
            // 
            // LifeBox
            // 
            this.LifeBox.Location = new System.Drawing.Point(190, 55);
            this.LifeBox.Name = "LifeBox";
            this.LifeBox.Size = new System.Drawing.Size(290, 29);
            this.LifeBox.TabIndex = 1;
            // 
            // HealthBox
            // 
            this.HealthBox.Location = new System.Drawing.Point(190, 20);
            this.HealthBox.Name = "HealthBox";
            this.HealthBox.Size = new System.Drawing.Size(290, 29);
            this.HealthBox.TabIndex = 0;
            // 
            // VacationText
            // 
            this.VacationText.AutoSize = true;
            this.VacationText.Location = new System.Drawing.Point(27, 95);
            this.VacationText.Name = "VacationText";
            this.VacationText.Size = new System.Drawing.Size(134, 24);
            this.VacationText.TabIndex = 2;
            this.VacationText.Text = "Vacation Days:";
            // 
            // LifeText
            // 
            this.LifeText.AutoSize = true;
            this.LifeText.Location = new System.Drawing.Point(27, 60);
            this.LifeText.Name = "LifeText";
            this.LifeText.Size = new System.Drawing.Size(132, 24);
            this.LifeText.TabIndex = 1;
            this.LifeText.Text = "Life Insurance:";
            // 
            // HealthText
            // 
            this.HealthText.AutoSize = true;
            this.HealthText.Location = new System.Drawing.Point(27, 25);
            this.HealthText.Name = "HealthText";
            this.HealthText.Size = new System.Drawing.Size(157, 24);
            this.HealthText.TabIndex = 0;
            this.HealthText.Text = "Health Insurance:";
            // 
            // EmployeeTypeGroup
            // 
            this.EmployeeTypeGroup.Controls.Add(this.SalaryBox);
            this.EmployeeTypeGroup.Controls.Add(this.salaryText);
            this.EmployeeTypeGroup.Controls.Add(this.HWBox);
            this.EmployeeTypeGroup.Controls.Add(this.HRBox);
            this.EmployeeTypeGroup.Controls.Add(this.HWText);
            this.EmployeeTypeGroup.Controls.Add(this.HRText);
            this.EmployeeTypeGroup.Controls.Add(this.salaryEmployee);
            this.EmployeeTypeGroup.Controls.Add(this.hourlyEmployee);
            this.EmployeeTypeGroup.Location = new System.Drawing.Point(12, 199);
            this.EmployeeTypeGroup.Name = "EmployeeTypeGroup";
            this.EmployeeTypeGroup.Size = new System.Drawing.Size(499, 140);
            this.EmployeeTypeGroup.TabIndex = 1;
            this.EmployeeTypeGroup.TabStop = false;
            this.EmployeeTypeGroup.Text = "Employee Type";
            // 
            // SalaryBox
            // 
            this.SalaryBox.Location = new System.Drawing.Point(190, 56);
            this.SalaryBox.Name = "SalaryBox";
            this.SalaryBox.Size = new System.Drawing.Size(290, 29);
            this.SalaryBox.TabIndex = 4;
            // 
            // salaryText
            // 
            this.salaryText.AutoSize = true;
            this.salaryText.Location = new System.Drawing.Point(31, 59);
            this.salaryText.Name = "salaryText";
            this.salaryText.Size = new System.Drawing.Size(66, 24);
            this.salaryText.TabIndex = 6;
            this.salaryText.Text = "Salary:";
            // 
            // HWBox
            // 
            this.HWBox.Location = new System.Drawing.Point(190, 94);
            this.HWBox.Name = "HWBox";
            this.HWBox.Size = new System.Drawing.Size(290, 29);
            this.HWBox.TabIndex = 3;
            // 
            // HRBox
            // 
            this.HRBox.Location = new System.Drawing.Point(190, 56);
            this.HRBox.Name = "HRBox";
            this.HRBox.Size = new System.Drawing.Size(290, 29);
            this.HRBox.TabIndex = 2;
            // 
            // HWText
            // 
            this.HWText.AutoSize = true;
            this.HWText.Location = new System.Drawing.Point(27, 97);
            this.HWText.Name = "HWText";
            this.HWText.Size = new System.Drawing.Size(142, 24);
            this.HWText.TabIndex = 3;
            this.HWText.Text = "Hours Worked: ";
            // 
            // HRText
            // 
            this.HRText.AutoSize = true;
            this.HRText.Location = new System.Drawing.Point(27, 59);
            this.HRText.Name = "HRText";
            this.HRText.Size = new System.Drawing.Size(114, 24);
            this.HRText.TabIndex = 2;
            this.HRText.Text = "Salary Rate: ";
            // 
            // salaryEmployee
            // 
            this.salaryEmployee.AutoSize = true;
            this.salaryEmployee.Location = new System.Drawing.Point(148, 22);
            this.salaryEmployee.Name = "salaryEmployee";
            this.salaryEmployee.Size = new System.Drawing.Size(79, 28);
            this.salaryEmployee.TabIndex = 1;
            this.salaryEmployee.TabStop = true;
            this.salaryEmployee.Text = "Salary";
            this.salaryEmployee.UseVisualStyleBackColor = true;
            this.salaryEmployee.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // hourlyEmployee
            // 
            this.hourlyEmployee.AutoSize = true;
            this.hourlyEmployee.Location = new System.Drawing.Point(53, 22);
            this.hourlyEmployee.Name = "hourlyEmployee";
            this.hourlyEmployee.Size = new System.Drawing.Size(83, 28);
            this.hourlyEmployee.TabIndex = 0;
            this.hourlyEmployee.TabStop = true;
            this.hourlyEmployee.Text = "Hourly";
            this.hourlyEmployee.UseVisualStyleBackColor = true;
            this.hourlyEmployee.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // EmployeeInfoGroup
            // 
            this.EmployeeInfoGroup.Controls.Add(this.hireDateText);
            this.EmployeeInfoGroup.Controls.Add(this.ssnText);
            this.EmployeeInfoGroup.Controls.Add(this.lastNameText);
            this.EmployeeInfoGroup.Controls.Add(this.label1);
            this.EmployeeInfoGroup.Controls.Add(this.firstNameText);
            this.EmployeeInfoGroup.Controls.Add(this.firstNameLabel);
            this.EmployeeInfoGroup.Controls.Add(this.lastNameLabel);
            this.EmployeeInfoGroup.Controls.Add(this.ssnLabel);
            this.EmployeeInfoGroup.Location = new System.Drawing.Point(12, 20);
            this.EmployeeInfoGroup.Name = "EmployeeInfoGroup";
            this.EmployeeInfoGroup.Size = new System.Drawing.Size(498, 173);
            this.EmployeeInfoGroup.TabIndex = 0;
            this.EmployeeInfoGroup.TabStop = false;
            this.EmployeeInfoGroup.Text = "Employee Info";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(531, 565);
            this.Controls.Add(this.EmployeeInfoGroup);
            this.Controls.Add(this.EmployeeTypeGroup);
            this.Controls.Add(this.GroupBenefitsBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.submitButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InputForm";
            this.Text = "Employee Input Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBenefitsBox.ResumeLayout(false);
            this.GroupBenefitsBox.PerformLayout();
            this.EmployeeTypeGroup.ResumeLayout(false);
            this.EmployeeTypeGroup.PerformLayout();
            this.EmployeeInfoGroup.ResumeLayout(false);
            this.EmployeeInfoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label ssnLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox firstNameText;
        public System.Windows.Forms.TextBox lastNameText;
        public System.Windows.Forms.TextBox ssnText;
        public System.Windows.Forms.TextBox hireDateText;
        private System.Windows.Forms.GroupBox GroupBenefitsBox;
        private System.Windows.Forms.Label VacationText;
        private System.Windows.Forms.Label LifeText;
        private System.Windows.Forms.Label HealthText;
        public System.Windows.Forms.TextBox HealthBox;
        public System.Windows.Forms.TextBox VacBox;
        public System.Windows.Forms.TextBox LifeBox;
        public System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox EmployeeTypeGroup;
        private System.Windows.Forms.GroupBox EmployeeInfoGroup;
        public System.Windows.Forms.RadioButton salaryEmployee;
        public System.Windows.Forms.RadioButton hourlyEmployee;
        public System.Windows.Forms.TextBox HWBox;
        public System.Windows.Forms.TextBox HRBox;
        public System.Windows.Forms.TextBox SalaryBox;
        public System.Windows.Forms.Label HWText;
        public System.Windows.Forms.Label HRText;
        public System.Windows.Forms.Label salaryText;
    }
}