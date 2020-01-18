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
    public partial class SeasonalTicketStepOne : Form
    {
        List<PictureBox> LineTypes { get; set; }
        List<PictureBox> TimeSpans { get; set; }
        private bool isLineTypeSelected;
        private bool isTimeSpanSelected;
        private int lineTypeNumber;
        private int timeSpanNumber;
            
        public SeasonalTicketStepOne()
        {
            InitializeComponent();
            LineTypes = new List<PictureBox> { lineType1, lineType2, lineType3, lineType4, lineType5 };
            var lineTypesLabels = new List<Label> { label1, label2, label3, label4, label5 };
            TimeSpans = new List<PictureBox> { timeSpan1, timeSpan2, timeSpan3, timeSpan4 };
            var timeSpanTypesLabels = new List<Label> { label6, label7, label8, label9 };
            string basePath = System.IO.Path.GetFullPath(@"..\..\");
            Image selectedImage = new Bitmap(basePath + "img\\background.png");
            this.BackgroundImage = selectedImage;

            for (int i = 0; i < LineTypes.Count; i++)
            {
                LineTypes[i].Click += selectLineType;
                lineTypesLabels[i].Click += selectLineType;
                bindPictureBoxAndLabel(LineTypes[i], lineTypesLabels[i]);
            }

            for (int i = 0; i < TimeSpans.Count; i++)
            {
                TimeSpans[i].Click += selectTimeSpan;
                timeSpanTypesLabels[i].Click += selectTimeSpan;
                bindPictureBoxAndLabel(TimeSpans[i], timeSpanTypesLabels[i]);
            }

        }

        private void selectLineType(object sender, EventArgs e)
        {
            string basePath = System.IO.Path.GetFullPath(@"..\..\");
            Image selectedImage = new Bitmap(basePath + "img\\SeasonTicketMenuSelected.png");
            
            foreach (var box in LineTypes)
            {
                Image baseImage = new Bitmap(basePath + "img\\SeasonTicketMenu.png");
                box.Image = baseImage;
            }

            PictureBox clickedBox;
            if (sender is PictureBox)
            {
                clickedBox = sender as PictureBox;
            }
            else
            {
                var clickedLabel = sender as Label;
                clickedBox = clickedLabel.Parent as PictureBox;
            }
            clickedBox.Image = selectedImage;
            lineTypeNumber = int.Parse(clickedBox.Tag.ToString());
            isLineTypeSelected = true;
            if (isTimeSpanSelected)
            {
                goToStep2();
            }
        }

        private void selectTimeSpan(object sender, EventArgs e)
        {
            string basePath = System.IO.Path.GetFullPath(@"..\..\");
            Image selectedImage = new Bitmap(basePath + "img\\SeasonTicketMenuSelected.png");

            foreach (var box in TimeSpans)
            {
                Image baseImage = new Bitmap(basePath + "img\\SeasonTicketMenu.png");
                box.Image = baseImage;
            }

            PictureBox clickedBox;
            if (sender is PictureBox)
            {
                clickedBox = sender as PictureBox;
            }
            else
            {
                var clickedLabel = sender as Label;
                clickedBox = clickedLabel.Parent as PictureBox;
            }
            clickedBox.Image = selectedImage;

            timeSpanNumber = int.Parse(clickedBox.Tag.ToString());
            isTimeSpanSelected = true;
            if (isLineTypeSelected)
            {
                goToStep2();
            }
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

        private void goToStep2()
        {
            var step2ViewModel = new SeasonalTicketStepTwoViewModel(lineTypeNumber, timeSpanNumber);
            Close();
            if (step2ViewModel.TicketPrices.Count == 1)
            {
                var step2 = new SeasonalTicketStepTwoSingle(step2ViewModel);
                step2.Show();
            }
            else if (timeSpanNumber == 0)
            {
                var step2 = new SeasonalTicketStepTwo30Days(step2ViewModel);
                step2.Show();
            }
            else
            {
                var step2 = new SeasonalTicketStepTwo1Month(step2ViewModel);
                step2.Show();
            }
            
        }

        private void timeSpan2_Click(object sender, EventArgs e)
        {

        }

        private void LineTypesLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SeasonalTicketStepOne_Load(object sender, EventArgs e)
        {

        }
    }
}
