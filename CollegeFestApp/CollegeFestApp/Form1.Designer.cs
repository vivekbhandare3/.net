namespace CollegeFestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Label for Prompt
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(311, 100);
            this.lblPrompt.Size = new System.Drawing.Size(200, 20);
            this.lblPrompt.Text = "Enter Number of People Attending:";

            // TextBox for User Input
            this.txtPeople.Location = new System.Drawing.Point(520, 100);
            this.txtPeople.Size = new System.Drawing.Size(100, 20);

            // Button for Calculation
            this.btnCalculate.Location = new System.Drawing.Point(387, 150);
            this.btnCalculate.Size = new System.Drawing.Size(150, 30);
            this.btnCalculate.Text = "Calculate Bill";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // Label for Result Display
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(387, 200);
            this.lblResult.Size = new System.Drawing.Size(250, 20);
            this.lblResult.Text = "Total Catering & Decoration Cost: ";

            // Form Configuration
            this.ClientSize = new System.Drawing.Size(899, 386);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.txtPeople);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "College Fest Bill Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
    }
}
