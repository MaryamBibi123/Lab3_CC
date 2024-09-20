namespace Lab3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // TextBox for input
        private System.Windows.Forms.TextBox txtInput;
        // Button to trigger validation
        private System.Windows.Forms.Button btnValidate;
        // Label to display validation result
        private System.Windows.Forms.Label lblResult;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(50, 50);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(200, 22);
            this.txtInput.TabIndex = 0;

            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(50, 100);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(200, 30);
            this.btnValidate.TabIndex = 1;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(50, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 2;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Lexical Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
