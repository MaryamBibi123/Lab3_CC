using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnFindWords_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();
            string pattern = @"\b[tT]\w*|\b[mM]\w*"; // Regex pattern to find words starting with 't' or 'm'
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            List<string> results = new List<string>();

            foreach (Match match in matches)
            {
                results.Add(match.Value);
            }

            // Clear existing rows
            dataGridView1.Rows.Clear();

            // Populate the DataGridView with results
            foreach (var result in results)
            {
                dataGridView1.Rows.Add(result);
            }

            // Show result count
            lblResult.Text = $"Found {results.Count} words starting with 't' or 'm'.";
        }
    }
}
