using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10458556_APPR7112
{

    public partial class ReportIssuesForm : Form
    {
        List<Issue> issues = new List<Issue>();

        public ReportIssuesForm()
        {
            InitializeComponent();

            lstCategory.Items.AddRange(new string[]
            {
                "Water Problem",
                "Road Damage",
                "Power Outage",
                "Waste Collection Issue",
                "Sanitation",
                "Utilities"
            });

            // Attach event handlers for input fields
            txtLocation.TextChanged += new EventHandler(UpdateProgressBar);
            lstCategory.SelectedIndexChanged += new EventHandler(UpdateProgressBar);
            rtbDescription.TextChanged += new EventHandler(UpdateProgressBar);

        }

        private void UpdateProgressBar(object sender, EventArgs e)
        {
            int progress = 0;

            // Check how much of the form is filled and update the progress
            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
                progress += 33;

            if (lstCategory.SelectedIndex != -1)
                progress += 33;

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
                progress += 34;

            progressBar.Value = progress;
            progressBar.Visible = true;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string location = txtLocation.Text;
            string category = lstCategory.SelectedItem?.ToString() ?? "No Category Selected";
            string description = rtbDescription.Text;

            // Validation to ensure necessary fields are filled
            if (string.IsNullOrWhiteSpace(location))
            {
                MessageBox.Show("Please enter a location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           

            // Optionally clear the form
            txtLocation.Clear();
            rtbDescription.Clear();
            lstCategory.Items.Clear();


            // Reset the ProgressBar after submission
            progressBar.Value = 0;
            progressBar.Visible = false;
            MessageBox.Show($"Location: {location}\nCategory: {category}\nDescription: {description}", "Issue Reported", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // Set file dialog properties
            openFileDialog.Title = "Select a File to Upload";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png|Document Files|*.pdf;*.docx|All Files|*.*"; // You can adjust the filter based on the file types you expect
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                lblFileName.Text = $"Selected File: {filePath}";
            }


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Define the gradient colors (Navy and a lighter shade)
            Color color1 = Color.Navy;
            Color color2 = Color.Blue;

            // Create a linear gradient brush
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 90F))
            {
                // Fill the background with the gradient
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }
    }
}