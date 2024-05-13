using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chp6_prob6
{
    public partial class Form1 : Form
    {
        const decimal stayPerDay = 3500.00m;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private decimal CalcStayCharges(int day)
        {
            return stayPerDay * day;
        }
        private decimal CalcMiscCharges(decimal foodBill, decimal spaBill, decimal carRental, decimal medicalBill)
        {
            return foodBill + spaBill + carRental + medicalBill;
        }
        private decimal CalcTotalCharges(decimal stayBill, decimal miscellaneous)
        {
            return stayBill + miscellaneous;
        }
        private bool InputIsValid(out int days, out decimal fb, out decimal sb, out decimal cb, out decimal mb)
        {
            if (int.TryParse(textBox1.Text, out days) &&
            decimal.TryParse(textBox2.Text, out sb) &&
            decimal.TryParse(textBox3.Text, out cb) &&
            decimal.TryParse(textBox4.Text, out mb ) &&
          


        }


        private void button1_Click(object sender, EventArgs e)
        {
            int days;
            decimal fb, sb, cb, mb;
            decimal stayCharge, miscCharge;
            decimal totalCharge;

            if (InputIsValid(out days, out fb, out sb, out cb, out mb))
            {
                stayCharge = CalcStayCharges(days);
                miscCharge = CalcMiscCharges(fb, sb, cb, mb);
                totalCharge = CalcTotalCharges(stayCharge, miscCharge);
                MessageBox.Show("總金額");
            }

        }



    }
}



