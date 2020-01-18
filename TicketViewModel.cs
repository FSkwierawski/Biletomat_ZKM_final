using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biletomat
{
    public class TicketViewModel
    {
        public PictureBox PlusButton { get; set; }
        public PictureBox MinusButton { get; set; }
        public PictureBox TicketImage { get; set; }
        public Label NumberOfTickets { get; set; }
        public double Price { get; set; }
    }
}
