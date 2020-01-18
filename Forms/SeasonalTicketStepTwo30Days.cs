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
    public partial class SeasonalTicketStepTwo30Days : Form
    {
        private readonly SeasonalTicketStepTwoViewModel viewModel;
        private DateTime extensionDate;
        private DateTime expirationDate;

        public SeasonalTicketStepTwo30Days(SeasonalTicketStepTwoViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            expirationDate = DateTime.Now;
            extensionDate = expirationDate.AddDays(1);
            extensionDateLabel.Text = extensionDate.ToString("dd-MM-yyyy");
            expirationDateLabel.Text = expirationDate.ToString("dd-MM-yyyy");
            string basePath = System.IO.Path.GetFullPath(@"..\..\");
            Image selectedImage = new Bitmap(basePath + "img\\background.png");
            this.BackgroundImage = selectedImage;

            var pos1 = this.PointToScreen(label2.Location);
            pos1 = lineType1.PointToClient(pos1);
            label2.Parent = lineType1;
            label2.Location = pos1;
            label2.BackColor = Color.Transparent;

            var pos2 = this.PointToScreen(extensionDateLabel.Location);
            pos2 = lineType1.PointToClient(pos2);
            extensionDateLabel.Parent = lineType1;
            extensionDateLabel.Location = pos2;
            extensionDateLabel.BackColor = Color.Transparent;

            var pos3 = this.PointToScreen(expirationDateLabel.Location);
            pos3 = pictureBox1.PointToClient(pos3);
            expirationDateLabel.Parent = pictureBox1;
            expirationDateLabel.Location = pos3;
            expirationDateLabel.BackColor = Color.Transparent;

            var pos4 = this.PointToScreen(label1.Location);
            pos4 = pictureBox1.PointToClient(pos4);
            label1.Parent = pictureBox1;
            label1.Location = pos4;
            label1.BackColor = Color.Transparent;

            var pos5 = this.PointToScreen(label6.Location);
            pos5 = pictureBox2.PointToClient(pos5);
            label6.Parent = pictureBox2;
            label6.Location = pos5;
            label6.BackColor = Color.Transparent;

            var pos6 = this.PointToScreen(label7.Location);
            pos6 = pictureBox3.PointToClient(pos6);
            label7.Parent = pictureBox3;
            label7.Location = pos6;
            label7.BackColor = Color.Transparent;

            var pos7 = this.PointToScreen(label8.Location);
            pos7 = pictureBox4.PointToClient(pos7);
            label8.Parent = pictureBox4;
            label8.Location = pos7;
            label8.BackColor = Color.Transparent;

            var pos8 = this.PointToScreen(label9.Location);
            pos8 = pictureBox5.PointToClient(pos8);
            label9.Parent = pictureBox5;
            label9.Location = pos8;
            label9.BackColor = Color.Transparent;

            var pos9 = this.PointToScreen(label10.Location);
            pos9 = pictureBox6.PointToClient(pos9);
            label10.Parent = pictureBox6;
            label10.Location = pos9;
            label10.BackColor = Color.Transparent;

            var pos11 = this.PointToScreen(label11.Location);
            pos11 = pictureBox2.PointToClient(pos11);
            label11.Parent = pictureBox2;
            label11.Location = pos11;
            label11.BackColor = Color.Transparent;
            label11.Text = viewModel.TicketPrices[0].ToString() + " zł";

            var pos12 = this.PointToScreen(label12.Location);
            pos12 = pictureBox3.PointToClient(pos12);
            label12.Parent = pictureBox3;
            label12.Location = pos12;
            label12.BackColor = Color.Transparent;
            label12.Text = viewModel.TicketPrices[1].ToString() + " zł";

            var pos13 = this.PointToScreen(label13.Location);
            pos13 = pictureBox4.PointToClient(pos13);
            label13.Parent = pictureBox4;
            label13.Location = pos13;
            label13.BackColor = Color.Transparent;
            label13.Text = viewModel.TicketPrices[2].ToString() + " zł";

            var pos14 = this.PointToScreen(label14.Location);
            pos14 = pictureBox5.PointToClient(pos14);
            label14.Parent = pictureBox5;
            label14.Location = pos14;
            label14.BackColor = Color.Transparent;
            label14.Text = viewModel.TicketPrices[3].ToString() + " zł";

            var pos15 = this.PointToScreen(label15.Location);
            pos15 = pictureBox6.PointToClient(pos15);
            label15.Parent = pictureBox6;
            label15.Location = pos15;
            label15.BackColor = Color.Transparent;
            label15.Text = viewModel.TicketPrices[4].ToString() + " zł";
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Close();
            var stepOne = new SeasonalTicketStepOne();
            stepOne.Show();
        }

        private void upDay_Click(object sender, EventArgs e)
        {

            extensionDate = extensionDate.AddDays(1);
            extensionDateLabel.Text = extensionDate.ToString("dd-MM-yyyy");
            validateExtensionDate();

        }

        private void downDay_Click(object sender, EventArgs e)
        {

            extensionDate = extensionDate.AddDays(-1);
            extensionDateLabel.Text = extensionDate.ToString("dd-MM-yyyy");
            validateExtensionDate();
        }

        private void upMonth_Click(object sender, EventArgs e)
        {

            extensionDate = extensionDate.AddMonths(1);
            extensionDateLabel.Text = extensionDate.ToString("dd-MM-yyyy");
            validateExtensionDate();

        }

        private void downMonth_Click(object sender, EventArgs e)
        {

            extensionDate = extensionDate.AddMonths(-1);
            extensionDateLabel.Text = extensionDate.ToString("dd-MM-yyyy");
            validateExtensionDate();

        }

        private void upYear_Click(object sender, EventArgs e)
        {

            extensionDate = extensionDate.AddYears(1);
            extensionDateLabel.Text = extensionDate.ToString("dd-MM-yyyy");
            validateExtensionDate();

        }

        private void downYear_Click(object sender, EventArgs e)
        {
            extensionDate = extensionDate.AddYears(-1);
            extensionDateLabel.Text = extensionDate.ToString("dd-MM-yyyy");
            validateExtensionDate();

        }

        private void validateExtensionDate()
        {
            if (DateTime.Compare(expirationDate, extensionDate) > 0)
            {
                extensionDate = expirationDate;
                extensionDateLabel.Text = extensionDate.ToString("dd-MM-yyyy");
            }
        }
    }
}
