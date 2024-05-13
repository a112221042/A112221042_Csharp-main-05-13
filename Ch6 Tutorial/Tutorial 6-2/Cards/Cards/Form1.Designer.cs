namespace Cards
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
            this.cardListBox = new System.Windows.Forms.ListBox();
            this.showCardButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.cardPanel = new System.Windows.Forms.Panel();
            this.kingClubsPictureBox = new System.Windows.Forms.PictureBox();
            this.tenHeartsPictureBox = new System.Windows.Forms.PictureBox();
            this.aceSpadesPictureBox = new System.Windows.Forms.PictureBox();
            this.cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingClubsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHeartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardListBox
            // 
            this.cardListBox.FormattingEnabled = true;
            this.cardListBox.ItemHeight = 18;
            this.cardListBox.Items.AddRange(new object[] {
            "黑桃Ace",
            "紅心10",
            "梅花K"});
            this.cardListBox.Location = new System.Drawing.Point(171, 215);
            this.cardListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardListBox.Name = "cardListBox";
            this.cardListBox.Size = new System.Drawing.Size(126, 76);
            this.cardListBox.TabIndex = 3;
            // 
            // showCardButton
            // 
            this.showCardButton.Location = new System.Drawing.Point(117, 300);
            this.showCardButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showCardButton.Name = "showCardButton";
            this.showCardButton.Size = new System.Drawing.Size(112, 32);
            this.showCardButton.TabIndex = 4;
            this.showCardButton.Text = "Show Card";
            this.showCardButton.UseVisualStyleBackColor = true;
            this.showCardButton.Click += new System.EventHandler(this.showCardButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(238, 300);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 32);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cardPanel
            // 
            this.cardPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cardPanel.Controls.Add(this.kingClubsPictureBox);
            this.cardPanel.Controls.Add(this.tenHeartsPictureBox);
            this.cardPanel.Controls.Add(this.aceSpadesPictureBox);
            this.cardPanel.Location = new System.Drawing.Point(21, 17);
            this.cardPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(426, 185);
            this.cardPanel.TabIndex = 7;
            // 
            // kingClubsPictureBox
            // 
            this.kingClubsPictureBox.Image = global::Cards.Properties.Resources.King_Clubs;
            this.kingClubsPictureBox.Location = new System.Drawing.Point(284, 11);
            this.kingClubsPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kingClubsPictureBox.Name = "kingClubsPictureBox";
            this.kingClubsPictureBox.Size = new System.Drawing.Size(128, 159);
            this.kingClubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kingClubsPictureBox.TabIndex = 5;
            this.kingClubsPictureBox.TabStop = false;
            this.kingClubsPictureBox.Visible = false;
            // 
            // tenHeartsPictureBox
            // 
            this.tenHeartsPictureBox.Image = global::Cards.Properties.Resources._10_Hearts;
            this.tenHeartsPictureBox.Location = new System.Drawing.Point(147, 11);
            this.tenHeartsPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tenHeartsPictureBox.Name = "tenHeartsPictureBox";
            this.tenHeartsPictureBox.Size = new System.Drawing.Size(128, 159);
            this.tenHeartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tenHeartsPictureBox.TabIndex = 4;
            this.tenHeartsPictureBox.TabStop = false;
            this.tenHeartsPictureBox.Visible = false;
            // 
            // aceSpadesPictureBox
            // 
            this.aceSpadesPictureBox.Image = global::Cards.Properties.Resources.Ace_Spades;
            this.aceSpadesPictureBox.Location = new System.Drawing.Point(10, 11);
            this.aceSpadesPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aceSpadesPictureBox.Name = "aceSpadesPictureBox";
            this.aceSpadesPictureBox.Size = new System.Drawing.Size(128, 159);
            this.aceSpadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.aceSpadesPictureBox.TabIndex = 3;
            this.aceSpadesPictureBox.TabStop = false;
            this.aceSpadesPictureBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 343);
            this.Controls.Add(this.cardPanel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.showCardButton);
            this.Controls.Add(this.cardListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Cards";
            this.cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kingClubsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenHeartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aceSpadesPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox cardListBox;
        private System.Windows.Forms.Button showCardButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel cardPanel;
        private System.Windows.Forms.PictureBox kingClubsPictureBox;
        private System.Windows.Forms.PictureBox tenHeartsPictureBox;
        private System.Windows.Forms.PictureBox aceSpadesPictureBox;
    }
}

