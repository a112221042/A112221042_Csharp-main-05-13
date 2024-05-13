using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void switchButton_Click(object sender, EventArgs e)
        {
            if(lightOnPictureBox.Visible == true)
            {
                TurnLightOff();
            }
            else
            {
                TurnLightOn();
            }
       
        }
        public void TurnLightOff()
        {
            lightOffPictureBox.Visible = true;
            lightOnPictureBox.Visible =false;
            lightStateLabel.Text = "OFF";
        }
        public void TurnLightOn()
        {
            lightOffPictureBox.Visible = false;
            lightOnPictureBox.Visible =true;
            lightStateLabel.Text = "ON";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void lightOnPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lightOffPictureBox.Image = Properties.Resources.LightOn;
            lightOffPictureBox.Image = Properties.Resources.LightOff;
            lightOffPictureBox.Visible = false;
            lightOffPictureBox.Visible = true;
            lightStateLabel.Text = "OFF";
        }
    }
}
