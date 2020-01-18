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
    public partial class SeasonalTicketStepTwo1Month : Form
    {
        private readonly SeasonalTicketStepTwoViewModel viewModel;

        public SeasonalTicketStepTwo1Month(SeasonalTicketStepTwoViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            string basePath = System.IO.Path.GetFullPath(@"..\..\");
            Image selectedImage = new Bitmap(basePath + "img\\background.png");
            this.BackgroundImage = selectedImage;
            #region
            var pos1 = this.PointToScreen(label1.Location);
            pos1 = pictureBox1.PointToClient(pos1);
            label1.Parent = pictureBox1;
            label1.Location = pos1;
            label1.BackColor = Color.Transparent;
            label1.Text = viewModel.TicketPrices[0].ToString() + " zł";

            var pos2 = this.PointToScreen(label2.Location);
            pos2 = pictureBox2.PointToClient(pos2);
            label2.Parent = pictureBox2;
            label2.Location = pos2;
            label2.BackColor = Color.Transparent;
            label2.Text = viewModel.TicketPrices[1].ToString() + " zł";

            var pos3 = this.PointToScreen(label3.Location);
            pos3 = pictureBox3.PointToClient(pos3);
            label3.Parent = pictureBox3;
            label3.Location = pos3;
            label3.BackColor = Color.Transparent;
            label3.Text = viewModel.TicketPrices[2].ToString() + " zł";

            var pos4 = this.PointToScreen(label4.Location);
            pos4 = pictureBox4.PointToClient(pos4);
            label4.Parent = pictureBox4;
            label4.Location = pos4;
            label4.BackColor = Color.Transparent;
            label4.Text = viewModel.TicketPrices[3].ToString() + " zł";

            var pos5 = this.PointToScreen(label5.Location);
            pos5 = pictureBox5.PointToClient(pos5);
            label5.Parent = pictureBox5;
            label5.Location = pos5;
            label5.BackColor = Color.Transparent;
            label5.Text = viewModel.TicketPrices[4].ToString() + " zł";

            var pos6 = this.PointToScreen(label6.Location);
            pos6 = pictureBox1.PointToClient(pos6);
            label6.Parent = pictureBox1;
            label6.Location = pos6;
            label6.BackColor = Color.Transparent;

            var pos7 = this.PointToScreen(label7.Location);
            pos7 = pictureBox2.PointToClient(pos7);
            label7.Parent = pictureBox2;
            label7.Location = pos7;
            label7.BackColor = Color.Transparent;

            var pos8 = this.PointToScreen(label8.Location);
            pos8 = pictureBox3.PointToClient(pos8);
            label8.Parent = pictureBox3;
            label8.Location = pos8;
            label8.BackColor = Color.Transparent;

            var pos9 = this.PointToScreen(label9.Location);
            pos9 = pictureBox4.PointToClient(pos9);
            label9.Parent = pictureBox4;
            label9.Location = pos9;
            label9.BackColor = Color.Transparent;

            var pos10 = this.PointToScreen(label10.Location);
            pos10 = pictureBox5.PointToClient(pos10);
            label10.Parent = pictureBox5;
            label10.Location = pos10;
            label10.BackColor = Color.Transparent;
        }
#endregion

        private void goBack_Click(object sender, EventArgs e)
        {
            Close();
            var stepOne = new SeasonalTicketStepOne();
            stepOne.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void SeasonalTicketStepTwo1Month_Load(object sender, EventArgs e)
        {

        }
    }
}
