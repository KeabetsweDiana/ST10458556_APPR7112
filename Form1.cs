using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST10458556_APPR7112
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable; 
            this.MinimizeBox = true; 
            this.MaximizeBox = true;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        // Method to customize label with transparent background and white font color
        private void CustomizeLabel(Label label)
        {
            label.BackColor = Color.Transparent;  // Set label background to transparent
            label.ForeColor = Color.White;        // Set label font color to white
        }

        // Override the OnPaint method to create a gradient background for the form
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

        private void button1_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportIssueForm = new ReportIssuesForm();
            reportIssueForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
