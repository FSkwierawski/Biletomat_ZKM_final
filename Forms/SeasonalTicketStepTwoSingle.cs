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
    public partial class SeasonalTicketStepTwoSingle : Form
    {
        private readonly SeasonalTicketStepTwoViewModel viewModel;

        public SeasonalTicketStepTwoSingle(SeasonalTicketStepTwoViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            string basePath = System.IO.Path.GetFullPath(@"..\..\");
            Image selectedImage = new Bitmap(basePath + "img\\background.png");
            this.BackgroundImage = selectedImage;

            label1.Text = "Linia: " + viewModel.LineType;
            label2.Text = "Okres: " + viewModel.TimeSpan;
            label3.Text = "Cena biletu: " + viewModel.TicketPrices.FirstOrDefault().ToString();

            var pos1 = this.PointToScreen(label1.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            label1.Parent = pictureBox1;
            label1.Location = pos1;
            label1.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(label2.Location);
            pos2 = pictureBox1.PointToClient(pos2);
            label2.Parent = pictureBox1;
            label2.Location = pos2;
            label2.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(label3.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            label3.Parent = pictureBox1;
            label3.Location = pos3;
            label3.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(label4.Location);
            pos4 = pictureBox1.PointToClient(pos4);
            label4.Parent = pictureBox1;
            label4.Location = pos4;
            label4.BackColor = Color.Transparent;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Close();
            var stepOne = new SeasonalTicketStepOne();
            stepOne.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
