using System;
using System.Windows.Forms;

namespace CollegeFestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Step 4: Define the event handler for button click
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int numPeople = Convert.ToInt32(txtPeople.Text);
                if (numPeople < 0)
                {
                    MessageBox.Show("Number of people cannot be negative.");
                    return;
                }

                // Create an instance of College (event publisher)
                College college = new College();

                // Create event subscribers
                Decorators decorators = new Decorators();
                Caterers caterers = new Caterers();

                // Subscribe to the event
                college.CollegeFestEvent += decorators.CalculateDecorationCost;
                college.CollegeFestEvent += caterers.CalculateCateringCost;

                // Trigger the event
                int totalBill = college.OnCollegeFestEvent(numPeople);

                // Display the total cost
                lblResult.Text = $"Total Catering & Decoration Cost: Rs. {totalBill}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
