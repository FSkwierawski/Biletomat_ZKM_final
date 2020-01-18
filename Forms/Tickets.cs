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
    public partial class Tickets : Form
    {
        List<TicketViewModel> TicketViews { get; set; }
        public Tickets()
        {
            InitializeComponent();
            var labels = new List<Label>() { noOfTickets1, noOfTickets2, noOfTickets3, noOfTickets4, noOfTickets5, noOfTickets6, noOfTickets7, noOfTickets8 };
            var plusButtons = new List<PictureBox> { plus1, plus2, plus3, plus4, plus5, plus6, plus7, plus8 };
            var minusButtons = new List<PictureBox> { minus1, minus2, minus3, minus4, minus5, minus6, minus7, minus8 };
            var tickets = new List<PictureBox> { ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8 };
            string basePath = System.IO.Path.GetFullPath(@"..\..\");
            Image selectedImage = new Bitmap(basePath + "img\\background.png");
            this.BackgroundImage = selectedImage;
            // USTAW CENY BILETOW W TAKIEJ KOLEJNOSCI JAK PICTURE BOXY
            var ticketPrices = new List<double> { 3.2, 3.8, 4.2, 13, 1.6, 1.9, 2.1, 6.5 };
            TicketViews = new List<TicketViewModel>();
            for (int i = 0; i < labels.Count; i++)
            {
                plusButtons[i].Click += plus_Click;
                minusButtons[i].Click += minus_Click;
                TicketViews.Add(new TicketViewModel
                {
                    MinusButton = minusButtons[i],
                    PlusButton = plusButtons[i],
                    TicketImage = tickets[i],
                    Price = ticketPrices[i],
                    NumberOfTickets = labels[i]
                });
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            var ticketView = TicketViews.Where(x => x.PlusButton  == sender as PictureBox).FirstOrDefault();
            var labelNumber = int.Parse(ticketView.NumberOfTickets.Text);
            ticketView.NumberOfTickets.Text = (++labelNumber).ToString();
            updateTotalCost();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            var ticketView = TicketViews.Where(x => x.MinusButton == sender as PictureBox).FirstOrDefault();
            var labelNumber = int.Parse(ticketView.NumberOfTickets.Text);
            if (labelNumber > 0)
            {
                ticketView.NumberOfTickets.Text = (--labelNumber).ToString();
            }
            else
            {
                ticketView.NumberOfTickets.Text = "0";
            }
            updateTotalCost();
        }

        private void updateTotalCost()
        {
            double cost = 0;
            foreach (var ticketView in TicketViews)
            {
                cost += ticketView.Price * Convert.ToDouble(ticketView.NumberOfTickets.Text);
            }
            TotalCost.Text = cost.ToString() + "zł";
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }

        private void bindPictureBoxAndLabel(PictureBox pictureBox, Label label)
        {
            var pos = PointToScreen(label.Location);
            pos = pictureBox.PointToClient(pos);
            label.Parent = pictureBox;
            label.Location = pos;
            label.BackColor = Color.Transparent;
        }
    }
}
