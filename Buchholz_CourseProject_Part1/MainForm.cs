using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Buchholz_CourseProject_Part1
{
    public partial class MainForm : Form
    {
        //class level references
        string[] titleArray = new string[5];    //song titles
        string[] artistArray = new string[5];   //associated artists
        string[] genreArray = new string[5];    //associated genres
        int[] yearArray = new int[5];           //associated years
        string[] urlArray = new string[5];      //associated url
        int songCount = 0;                      //current number of songs

        public MainForm()
        {
            InitializeComponent();
        }

        //Verification of  entered data. Returns true as long as entries are not empty. Returns false otherwise.
        private bool ValidInput()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(titleText.Text))
            {
                MessageBox.Show("Please Enter Song Title");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(artistText.Text))
            {
                MessageBox.Show("Please Enter the Artist Name");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(genreText.Text))
            {
                MessageBox.Show("Please Enter the Genre");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                MessageBox.Show("Please Enter the Year");
                isValid = false;
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                MessageBox.Show("Please Enter the URL");
                isValid = false;
            }
            return (isValid);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";

            //Verify using if-else loop statements
            if (songCount == titleArray.Length)
                MessageBox.Show("Song List is Full!");
            else if (ValidInput())
            {
                //Add titlle to ListBox and Song List
                songList.Items.Add(titleText.Text);
                titleArray[songCount] = titleText.Text;
                artistArray[songCount] = artistText.Text;
                genreArray[songCount] = genreText.Text;
                yearArray[songCount] = int.Parse(yearText.Text);
                urlArray[songCount] = urlText.Text;

                //Increment Song Counter
                songCount++;

                //Build Output Text
                sb.Append(titleText.Text);
                sb.Append(nl);
                sb.Append(artistText.Text);
                sb.Append(nl);
                sb.Append(genreText.Text);
                sb.Append(nl);
                sb.Append(yearText.Text);
                sb.Append(nl);
                sb.Append(urlText.Text);
                sb.Append(nl);
                sb.Append(nl);

                outputText.Text = sb.ToString();
            }
        }

        private bool SongInList(string songTitle)
        {
            bool found = false;

            foreach (var item in songList.Items)
            {
                string currentSong = item as string;
                //make not case sensitive
                if( songTitle.ToLower() == currentSong.ToLower() )
                {
                    found = true;
                }
            }

            return found;
        }

        private int GetSongIndex(string songTitle)
        {
            int songIndex = songList.Items.IndexOf(songTitle);
            return songIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            //Building the Output Text
            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);
            }

            //Put the Output text into the output textbox
            outputText.Text = sb.ToString();
        }

        private void findSongButton_Click(object sender, EventArgs e)
        {
            if (SongInList(titleText.Text))
            {
                StringBuilder sb = new StringBuilder(string.Empty);
                string nl = "\r\n";

                int songIndex = GetSongIndex(titleText.Text);

                //Build output Text
                sb.Append(titleArray[songIndex]);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex]);
                sb.Append(nl);
                sb.Append(urlArray[songIndex]);
                sb.Append(nl);

                outputText.Text = sb.ToString();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            titleText.Clear();
            artistText.Clear();
            genreText.Clear();
            yearText.Clear();
            urlText.Clear();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;
            string url = urlArray[songIndex];
            webViewDisplay.CoreWebView2.Navigate(url);
        }

        private void songList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            int songIndex = songList.SelectedIndex;

            //If song selected has index greater than -1, show details
            if (songIndex > -1)
            {
                //Build output Text
                sb.Append(titleArray[songIndex]);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex]);
                sb.Append(nl);
                sb.Append(urlArray[songIndex]);
                sb.Append(nl);

                outputText.Text = sb.ToString();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //set file pathing for saving data
            string filePath = "songList.txt";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                //Create a Header for Ease of Reading
                writer.WriteLine("Song Title | Artist | Genre | Year | URL");
                writer.WriteLine(new string('-', 75)); //creates a separater

                //Create a Loop through the songs to write the details
                for (int i = 0; i < songCount; i++)
                {
                    string songDetails = $"{titleArray[i]} | {artistArray[i]} | {genreArray[i]} | {yearArray[i]} | {urlArray[i]}";
                    writer.WriteLine(songDetails);
                }
            }

            MessageBox.Show("Songs Succesfully Saved.");

        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            //Set the Path to Load From
            string filePath = "songList.txt";

            using (StreamReader reader = new StreamReader(filePath))
            {
                //Clear any existing data
                songList.Items.Clear();
                songCount = 0;

                //Skip the Header Lines - Not Needed
                reader.ReadLine();
                reader.ReadLine();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    //Need to split the lines at '|'
                    string[] songDetails = line.Split('|');

                    if (songDetails.Length == 5)
                    {
                        //Assign the values
                        string title = songDetails[0];
                        string artist = songDetails[1];
                        string genre = songDetails[2];
                        int year = int.Parse(songDetails[3]);
                        string url = songDetails[4];

                        //Add to Array
                        titleArray[songCount] = title;
                        artistArray[songCount] = artist;
                        genreArray[songCount] = genre;
                        yearArray[songCount] = year;
                        urlArray[songCount] = url;

                        //Add to ListBox
                        songList.Items.Add(title);

                        //Increment Song Count
                        songCount++;
                    }
                }
            }

            MessageBox.Show("Songs Successfully Loaded.");
        }
    }
}
