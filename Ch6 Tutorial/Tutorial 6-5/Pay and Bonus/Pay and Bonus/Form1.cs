using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.


        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay = 0m;
            decimal bonus = 0m;
            decimal contrubution = 0m;

            if (inputIsValid(ref grossPay, ref bonus))
            {
                contrubution = (grossPay + bonus) * CONTRIB_RATE;
                contributionLabel.Text = contrubution.ToString("c");
            }
        }

        private bool inputIsValid(ref decimal grossPay, ref decimal bonus)
        {
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("錯誤");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("錯誤");
                return false;
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}