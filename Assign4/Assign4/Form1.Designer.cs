namespace Assign4
{
    partial class Form1
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cmbSize = new System.Windows.Forms.ComboBox();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.btnCalculateSimple = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(50, 30);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 0;
            this.txtQuantity.Text = "Enter Quantity";
            // 
            // cmbSize
            // 
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(50, 60);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.Size = new System.Drawing.Size(121, 21);
            this.cmbSize.TabIndex = 1;
            this.cmbSize.Text = "Options";
            // 
            // txtPromo
            // 
            this.txtPromo.Location = new System.Drawing.Point(50, 90);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(100, 20);
            this.txtPromo.TabIndex = 2;
            this.txtPromo.Text = "Enter Promo Code (if any)";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(50, 120);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Price";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Location = new System.Drawing.Point(50, 150);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblFinalPrice.TabIndex = 4;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(200, 30);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 5;
            this.txtNum1.Text = "Enter Number 1";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(200, 60);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 6;
            this.txtNum2.Text = "Enter Number 2";
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Location = new System.Drawing.Point(200, 90);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(121, 21);
            this.cmbOperation.TabIndex = 7;
            this.cmbOperation.Text = "Options";
            // 
            // btnCalculateSimple
            // 
            this.btnCalculateSimple.Location = new System.Drawing.Point(200, 120);
            this.btnCalculateSimple.Name = "btnCalculateSimple";
            this.btnCalculateSimple.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateSimple.TabIndex = 8;
            this.btnCalculateSimple.Text = "Calculate";
            this.btnCalculateSimple.Click += new System.EventHandler(this.btnCalculateSimple_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(200, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 235);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.cmbSize);
            this.Controls.Add(this.txtPromo);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.btnCalculateSimple);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "T-Shirt Order & Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.ComboBox cmbSize;
        private System.Windows.Forms.TextBox txtPromo;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.Button btnCalculateSimple;
        private System.Windows.Forms.Label lblResult;
    }
}
