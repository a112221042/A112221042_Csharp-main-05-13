using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_By_Ref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The SetToZero method accepts an int argument
        // by reference and sets it to zero.
      

        private void goButton_Click(object sender, EventArgs e)
        {
            // Declare some local int variables.
            int x =100, y=200, z = 300;

            // Display the values in those variables.
            outputListBox.Items.Add("x=" + x);
            outputListBox.Items.Add("y=" + y);
            outputListBox.Items.Add("z=" + z);

            outputListBox.Items.Add("-----------------------");
            SetToZero(x, y, z);


            outputListBox.Items.Add("x=" + x);
            outputListBox.Items.Add("y=" + y);
            outputListBox.Items.Add("z=" + z);
        }
        public void SetToZero(int x,int y,ref int z)
        {
            x = 0;
            y = 0;
            z = 0;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
