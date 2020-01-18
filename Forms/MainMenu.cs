using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biletomat
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();

            string basePath = System.IO.Path.GetFullPath(@"..\..\");
            Image selectedImage = new Bitmap(basePath + "img\\background.png");
            this.BackgroundImage = selectedImage;
        }

        private void MainMenuTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tickets tickets = new Tickets();
            tickets.Show();
        }

        private void MainMenuCityCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeasonalTicketStepOne seasonalTicketStepOne = new SeasonalTicketStepOne();
            seasonalTicketStepOne.Show();
        }
    }
}
