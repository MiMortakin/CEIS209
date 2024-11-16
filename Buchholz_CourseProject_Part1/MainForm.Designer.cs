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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.songList = new System.Windows.Forms.ListBox();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.allSongs = new System.Windows.Forms.Label();
            this.allDetails = new System.Windows.Forms.Label();
            this.findSongButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.playButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(3, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(55, 24);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title: ";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(79, 18);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(268, 29);
            this.titleText.TabIndex = 1;
            // 
            // artistText
            // 
            this.artistText.Location = new System.Drawing.Point(79, 55);
            this.artistText.Name = "artistText";
            this.artistText.Size = new System.Drawing.Size(268, 29);
            this.artistText.TabIndex = 3;
            // 
            // artistLabel
            // 
            this.artistLabel.AutoSize = true;
            this.artistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artistLabel.ForeColor = System.Drawing.Color.White;
            this.artistLabel.Location = new System.Drawing.Point(3, 55);
            this.artistLabel.Name = "artistLabel";
            this.artistLabel.Size = new System.Drawing.Size(60, 24);
            this.artistLabel.TabIndex = 2;
            this.artistLabel.Text = "Artist: ";
            // 
            // genreText
            // 
            this.genreText.Location = new System.Drawing.Point(79, 91);
            this.genreText.Name = "genreText";
            this.genreText.Size = new System.Drawing.Size(268, 29);
            this.genreText.TabIndex = 5;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLabel.ForeColor = System.Drawing.Color.White;
            this.genreLabel.Location = new System.Drawing.Point(3, 94);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(73, 24);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre: ";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(79, 128);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(268, 29);
            this.yearText.TabIndex = 7;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.White;
            this.yearLabel.Location = new System.Drawing.Point(3, 128);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(59, 24);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year: ";
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(79, 164);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(268, 29);
            this.urlText.TabIndex = 9;
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.ForeColor = System.Drawing.Color.White;
            this.urlLabel.Location = new System.Drawing.Point(3, 164);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(56, 24);
            this.urlLabel.TabIndex = 8;
            this.urlLabel.Text = "URL: ";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Silver;
            this.addButton.Location = new System.Drawing.Point(41, 215);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 38);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add Song";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.Color.DimGray;
            this.outputText.ForeColor = System.Drawing.Color.White;
            this.outputText.Location = new System.Drawing.Point(443, 386);
            this.outputText.Multiline = true;
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(491, 172);
            this.outputText.TabIndex = 11;
            // 
            // songList
            // 
            this.songList.BackColor = System.Drawing.Color.DimGray;
            this.songList.ForeColor = System.Drawing.Color.White;
            this.songList.FormattingEnabled = true;
            this.songList.HorizontalScrollbar = true;
            this.songList.ItemHeight = 24;
            this.songList.Location = new System.Drawing.Point(25, 386);
            this.songList.Name = "songList";
            this.songList.ScrollAlwaysVisible = true;
            this.songList.Size = new System.Drawing.Size(412, 172);
            this.songList.TabIndex = 12;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged_1);
            // 
            // allSongsButton
            // 
            this.allSongsButton.BackColor = System.Drawing.Color.Silver;
            this.allSongsButton.ForeColor = System.Drawing.Color.Black;
            this.allSongsButton.Location = new System.Drawing.Point(186, 259);
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Size = new System.Drawing.Size(116, 38);
            this.allSongsButton.TabIndex = 13;
            this.allSongsButton.Text = "Show All";
            this.allSongsButton.UseVisualStyleBackColor = false;
            this.allSongsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // allSongs
            // 
            this.allSongs.AutoSize = true;
            this.allSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allSongs.ForeColor = System.Drawing.Color.White;
            this.allSongs.Location = new System.Drawing.Point(38, 366);
            this.allSongs.Name = "allSongs";
            this.allSongs.Size = new System.Drawing.Size(65, 16);
            this.allSongs.TabIndex = 14;
            this.allSongs.Text = "Song List:";
            // 
            // allDetails
            // 
            this.allDetails.AutoSize = true;
            this.allDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDetails.ForeColor = System.Drawing.Color.White;
            this.allDetails.Location = new System.Drawing.Point(440, 366);
            this.allDetails.Name = "allDetails";
            this.allDetails.Size = new System.Drawing.Size(87, 16);
            this.allDetails.TabIndex = 15;
            this.allDetails.Text = "Song Details:";
            // 
            // findSongButton
            // 
            this.findSongButton.BackColor = System.Drawing.Color.Silver;
            this.findSongButton.Location = new System.Drawing.Point(41, 259);
            this.findSongButton.Name = "findSongButton";
            this.findSongButton.Size = new System.Drawing.Size(116, 38);
            this.findSongButton.TabIndex = 16;
            this.findSongButton.Text = "Find Song";
            this.findSongButton.UseVisualStyleBackColor = false;
            this.findSongButton.Click += new System.EventHandler(this.findSongButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.Location = new System.Drawing.Point(186, 215);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(116, 38);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear Song";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewDisplay.Location = new System.Drawing.Point(363, 18);
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Size = new System.Drawing.Size(571, 312);
            this.webViewDisplay.Source = new System.Uri("https://www.microsoft.com", System.UriKind.Absolute);
            this.webViewDisplay.TabIndex = 18;
            this.webViewDisplay.ZoomFactor = 1D;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Silver;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.playButton.Location = new System.Drawing.Point(600, 344);
            this.playButton.Margin = new System.Windows.Forms.Padding(1);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(116, 38);
            this.playButton.TabIndex = 19;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Silver;
            this.saveButton.Location = new System.Drawing.Point(41, 303);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 38);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save List";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.BackColor = System.Drawing.Color.Silver;
            this.loadButton.Location = new System.Drawing.Point(186, 303);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(116, 38);
            this.loadButton.TabIndex = 21;
            this.loadButton.Text = "Load List";
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(946, 567);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.findSongButton);
            this.Controls.Add(this.allDetails);
            this.Controls.Add(this.allSongs);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.songList);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Video Manager";
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
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
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Label allSongs;
        private System.Windows.Forms.Label allDetails;
        private System.Windows.Forms.Button findSongButton;
        private System.Windows.Forms.Button clearButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
    }
}

