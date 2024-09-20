namespace Lab3
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblResult;

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
            this.btnValidate = new System.Windows.Forms.Button();
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
            this.dataGridView1.Columns.Add("ScientificNotation", "Scientific Notation");

            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(50, 100);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(300, 30);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);

            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(50, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(300, 22);
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
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Scientific Notation Validator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
