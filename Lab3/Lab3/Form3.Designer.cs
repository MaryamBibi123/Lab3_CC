namespace Lab3
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFindWords = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(300, 200);
            this.dataGridView1.TabIndex = 0;

            // Add a column to the DataGridView
            this.dataGridView1.Columns.Add("Words", "Words Starting with T or M");

            // 
            // btnFindWords
            // 
            this.btnFindWords.Location = new System.Drawing.Point(50, 100);
            this.btnFindWords.Name = "btnFindWords";
            this.btnFindWords.Size = new System.Drawing.Size(300, 30);
            this.btnFindWords.TabIndex = 1;
            this.btnFindWords.Text = "Find Words";
            this.btnFindWords.UseVisualStyleBackColor = true;
            this.btnFindWords.Click += new System.EventHandler(this.btnFindWords_Click);

            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(50, 50);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 40);
            this.txtInput.TabIndex = 2;

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(50, 370);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 3;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnFindWords);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Word Finder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFindWords;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblResult;
    }
}
