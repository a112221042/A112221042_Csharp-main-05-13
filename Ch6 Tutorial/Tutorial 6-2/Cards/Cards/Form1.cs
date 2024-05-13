using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
           if(cardListBox.SelectedIndex != -1)
            {
               ShowCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("請選擇一張圖片");

            }
        }
        private void ShowCard(string card)
        {
            switch(card)
            {
                case "黑桃Ace":
                    ShowAceSpades();
                    break;
                case "紅心10":
                   ShowtenHearts();
                    break;
                default:
                    ShowkingClubs();
                    break;

            }

        }

        public void ShowAceSpades()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }

        public void ShowtenHearts()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }
        public void ShowkingClubs()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
