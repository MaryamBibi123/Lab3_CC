using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the "Validate" button click
        private void btnValidate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;

            // Regular expression for floating-point numbers of length not greater than 6
            string pattern = @"^[-+]?\d{0,3}(\.\d{1,3})?$";
            Regex regex = new Regex(pattern);

            // Check if the input matches the regular expression
            if (regex.IsMatch(input))
            {
                lblResult.Text = "Valid floating-point number";
            }
            else
            {
                lblResult.Text = "Invalid input. Length exceeds 6 characters or format is incorrect.";
            }
        }
    }
}
