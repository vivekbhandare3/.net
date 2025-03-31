using System;
using System.Windows.Forms;

namespace Assign4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbSize.Items.Add("Small (Rs. 125)");
            cmbSize.Items.Add("Medium (Rs. 175)");
            cmbSize.Items.Add("Large (Rs. 250)");
            cmbOperation.Items.Add("+");
            cmbOperation.Items.Add("-");
            cmbOperation.Items.Add("*");
            cmbOperation.Items.Add("/");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Get number of T-shirts
            int quantity;
            if (!int.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Get selected size price
            int pricePerShirt = 0;
            if (cmbSize.SelectedItem != null)
            {
                switch (cmbSize.SelectedItem.ToString())
                {
                    case "Small (Rs. 125)": pricePerShirt = 125; break;
                    case "Medium (Rs. 175)": pricePerShirt = 175; break;
                    case "Large (Rs. 250)": pricePerShirt = 250; break;
                    default: MessageBox.Show("Please select a size."); return;
                }
            }
            else
            {
                MessageBox.Show("Please select a T-shirt size.");
                return;
            }

            // Calculate base price
            double totalPrice = quantity * pricePerShirt;

            // Apply Promo Code
            if (txtPromo.Text == "TRUEBLUE")
            {
                totalPrice *= 0.9; // 10% discount
            }

            // Apply GST (9%)
            totalPrice *= 1.09;

            // Display final price
            lblFinalPrice.Text = "Final Price: Rs. " + totalPrice.ToString("0.00");
        }

        private void btnCalculateSimple_Click(object sender, EventArgs e)
        {
            // Simple Calculator Logic
            double num1, num2, result = 0;
            if (!double.TryParse(txtNum1.Text, out num1) || !double.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            string operation = cmbOperation.SelectedItem?.ToString();
            if (operation == null)
            {
                MessageBox.Show("Please select an operation.");
                return;
            }

            switch (operation)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = num1 / num2;
                    break;
                default:
                    MessageBox.Show("Invalid operation.");
                    return;
            }

            lblResult.Text = "Result: " + result.ToString("0.00");
        }
    }
}
