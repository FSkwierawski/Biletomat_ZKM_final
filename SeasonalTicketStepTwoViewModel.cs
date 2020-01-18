using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biletomat
{
    public class SeasonalTicketStepTwoViewModel
    {
        public string LineType { get; set; }
        public string TimeSpan { get; set; }
        public List<double> TicketPrices { get; set; }

        // Translate this table https://zkmgdynia.pl/files/Taryfa%20ZKM%20w%20Gdyni/A4_zkmgdynia_taryfa.pdf to ViewModel
        public SeasonalTicketStepTwoViewModel(int pos1, int pos2)
        {
            var lineTypes = new List<string> { "Zwykłe w granicach Gdyni",
                "Nocne, pospieszne i zwykłe w granicach Gdyni",
            "Nocne, pospieszne i zwykł w granicach Sopotu albo Rumi albo Gm. Kosakowo albo Gm. Żukowo albo Gm. Szemud albo Gm. Wejherowo",
            "Nocne, pospieszne i zwykłe w granicach Rumi, Redy i miasta Wejherowa albo Gm. Wejherowo i Rumi",
            "Nocne, pospieszne i zwykłe w obrębie sieci komunikacyjnej [w tym linie G, N1, 101 i 171] "};

            var timeSpans = new List<string> { "30-dniowy",
                "Miesięczny",
                "4-miesięczny ważny we wszystkie dni tygodnia 01.10-31.01 lub 01.02-31.05",
                "5-miesięczny ważny we wszystkie dni tygodnia 01.09-31.01 lub 01.02-31.06" };

            var prices = new double[,] { { 72, 36, 82, 41, 92, 156, 195 },
                                         { 86, 43, 94, 47, 107, 179, 223},
                                         { 58 ,29, 64, 32, 75, 122, 152},
                                         { 74, 37, 84, 42, 97, 160, 200},
                                         { 96, 48, 104, 52, 117, 198, 247}};
            LineType = lineTypes[pos1];
            TimeSpan = timeSpans[pos2];

            var tickets = new List<double>();
            if (pos2 == 0 || pos2 == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    tickets.Add(prices[pos1, i]);
                }
            }
            else
            {
                tickets.Add(prices[pos1, pos2 + 3]);
            }
            TicketPrices = tickets;
        }
    }
}
