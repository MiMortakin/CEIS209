namespace Buchholz_CourseProject_Part1
{
    partial class MainForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.artistLabel = new System.Windows.Forms.Label();
            this.genreText = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(23, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(64, 26);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title: ";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(102, 19);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(292, 32);
            this.titleText.TabIndex = 1;
            this.titleText.Click += new System.EventHandler(this.f);
            this.titleText.TextChanged += new System.EventHandler(this.titleText_TextChanged);
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(102, 57);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(292, 32);
            this.artistText.TabIndex = 3;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Location = new System.Drawing.Point(13, 57);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(74, 26);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "Artist: ";
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(102, 95);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(292, 32);
            this.genreText.TabIndex = 5;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(3, 98);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(84, 26);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre: ";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(102, 133);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(292, 32);
            this.yearText.TabIndex = 7;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(16, 136);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(71, 26);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year: ";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(102, 171);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(292, 32);
            this.urlText.TabIndex = 9;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(19, 174);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(68, 26);
            this.urlLabel.TabIndex = 8;
            this.urlLabel.Text = "URL: ";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(92, 209);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(137, 40);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(435, 19);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(382, 519);
            this.outputText.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 559);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreText);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.artistText);
            this.Controls.Add(this.artistLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Video Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.Label artistLabel;
        private System.Windows.Forms.TextBox genreText;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox outputText;
    }
}

