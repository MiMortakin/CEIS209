using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buchholz_CourseProject_Part1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void titleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";

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

        private void f(object sender, EventArgs e)
        {

        }
    }
}
