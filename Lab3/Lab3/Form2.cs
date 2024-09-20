using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            string pattern = @"^[+-]?\d+(\.\d+)?e[+-]?\d+$";
            Regex regex = new Regex(pattern);

            List<string> results = new List<string>();

            if (regex.IsMatch(input))
            {
                results.Add(input);
                lblResult.Text = "Valid scientific notation.";
            }
            else
            {
                lblResult.Text = "Invalid input. Please enter a valid scientific notation.";
            }

            // Clear existing rows
            dataGridView1.Rows.Clear();

            // Populate the DataGridView with results
            foreach (var result in results)
            {
                dataGridView1.Rows.Add(result);
            }
        }
    }
}
