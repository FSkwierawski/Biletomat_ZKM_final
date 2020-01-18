namespace Biletomat
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.MainMenuTicket = new System.Windows.Forms.PictureBox();
            this.MainMenuCityCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuTicket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuCityCard)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuTicket
            // 
            this.MainMenuTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainMenuTicket.Image = ((System.Drawing.Image)(resources.GetObject("MainMenuTicket.Image")));
            this.MainMenuTicket.Location = new System.Drawing.Point(361, 127);
            this.MainMenuTicket.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenuTicket.Name = "MainMenuTicket";
            this.MainMenuTicket.Size = new System.Drawing.Size(540, 150);
            this.MainMenuTicket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainMenuTicket.TabIndex = 1;
            this.MainMenuTicket.TabStop = false;
            this.MainMenuTicket.Click += new System.EventHandler(this.MainMenuTicket_Click);
            // 
            // MainMenuCityCard
            // 
            this.MainMenuCityCard.Image = ((System.Drawing.Image)(resources.GetObject("MainMenuCityCard.Image")));
            this.MainMenuCityCard.Location = new System.Drawing.Point(361, 356);
            this.MainMenuCityCard.Margin = new System.Windows.Forms.Padding(4);
            this.MainMenuCityCard.Name = "MainMenuCityCard";
            this.MainMenuCityCard.Size = new System.Drawing.Size(540, 150);
            this.MainMenuCityCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainMenuCityCard.TabIndex = 2;
            this.MainMenuCityCard.TabStop = false;
            this.MainMenuCityCard.Click += new System.EventHandler(this.MainMenuCityCard_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 665);
            this.Controls.Add(this.MainMenuCityCard);
            this.Controls.Add(this.MainMenuTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuTicket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuCityCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox MainMenuTicket;
        private System.Windows.Forms.PictureBox MainMenuCityCard;
    }
}

