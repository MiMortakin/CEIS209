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
            this.GroupBenefitsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(12, 28);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(106, 24);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(12, 63);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(104, 24);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // ssnLabel
            // 
            this.ssnLabel.AutoSize = true;
            this.ssnLabel.Location = new System.Drawing.Point(12, 98);
            this.ssnLabel.Name = "ssnLabel";
            this.ssnLabel.Size = new System.Drawing.Size(58, 24);
            this.ssnLabel.TabIndex = 2;
            this.ssnLabel.Text = "SSN: ";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(124, 23);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(290, 29);
            this.firstNameText.TabIndex = 0;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(124, 58);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(290, 29);
            this.lastNameText.TabIndex = 1;
            // 
            // ssnText
            // 
            this.ssnText.Location = new System.Drawing.Point(124, 93);
            this.ssnText.Name = "ssnText";
            this.ssnText.Size = new System.Drawing.Size(290, 29);
            this.ssnText.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitButton.Location = new System.Drawing.Point(68, 316);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(132, 37);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.LightCoral;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(256, 316);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(132, 37);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Cancel";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hire Date:";
            // 
            // hireDateText
            // 
            this.hireDateText.Location = new System.Drawing.Point(124, 128);
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
            this.GroupBenefitsBox.Location = new System.Drawing.Point(16, 176);
            this.GroupBenefitsBox.Name = "GroupBenefitsBox";
            this.GroupBenefitsBox.Size = new System.Drawing.Size(499, 134);
            this.GroupBenefitsBox.TabIndex = 4;
            this.GroupBenefitsBox.TabStop = false;
            this.GroupBenefitsBox.Text = "Benefits";
            // 
            // VacBox
            // 
            this.VacBox.Location = new System.Drawing.Point(190, 90);
            this.VacBox.Name = "VacBox";
            this.VacBox.Size = new System.Drawing.Size(290, 29);
            this.VacBox.TabIndex = 3;
            // 
            // LifeBox
            // 
            this.LifeBox.Location = new System.Drawing.Point(190, 55);
            this.LifeBox.Name = "LifeBox";
            this.LifeBox.Size = new System.Drawing.Size(290, 29);
            this.LifeBox.TabIndex = 2;
            // 
            // HealthBox
            // 
            this.HealthBox.Location = new System.Drawing.Point(190, 20);
            this.HealthBox.Name = "HealthBox";
            this.HealthBox.Size = new System.Drawing.Size(290, 29);
            this.HealthBox.TabIndex = 1;
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
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(531, 366);
            this.Controls.Add(this.GroupBenefitsBox);
            this.Controls.Add(this.hireDateText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.ssnText);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.ssnLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InputForm";
            this.Text = "Employee Input Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBenefitsBox.ResumeLayout(false);
            this.GroupBenefitsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}