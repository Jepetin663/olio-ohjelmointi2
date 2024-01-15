using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace LottoApp
{
    public partial class MainWindow : Window
    {
        private readonly Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TulostaButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtNumberOfRows.Text, out int numberOfRows) && numberOfRows > 0)
            {
                string selectedGame = ((ComboBoxItem)cmbPelivalinta.SelectedItem).Content.ToString();
                List<string> arvotutRivit = ArvoRivit(selectedGame, numberOfRows);

                txtArvotutRivit.Text = string.Join("\n", arvotutRivit);
            }
            else
            {
                MessageBox.Show("Syötä kelvollinen lukumäärä rivejä.");
            }
        }

        private void TyhjennaButton_Click(object sender, RoutedEventArgs e)
        {
            txtArvotutRivit.Text = string.Empty;
        }

        private void ViikonArvontaButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedGame = ((ComboBoxItem)cmbPelivalinta.SelectedItem).Content.ToString();
            List<string> viikonRivi = ArvoRivit(selectedGame, 1);

            MessageBox.Show($"Viikon arvottu rivi: {viikonRivi.First()}");
        }

        private void TarkastaButton_Click(object sender, RoutedEventArgs e)
        {
            string selectedGame = ((ComboBoxItem)cmbPelivalinta.SelectedItem).Content.ToString();
            List<string> arvotutRivit = ArvoRivit(selectedGame, 10); // Arvotaan 10 riviä tarkastusta varten

            int oikein = 0;
            string parasRivi = string.Empty;

            foreach (var rivi in arvotutRivit)
            {
                int oikeatNumerot = TarkastaRivi(selectedGame, rivi);
                if (oikeatNumerot > oikein)
                {
                    oikein = oikeatNumerot;
                    parasRivi = rivi;
                }
            }

            MessageBox.Show($"Paras rivi: {parasRivi}\nOikeat numerot: {oikein}");
        }

        private List<string> ArvoRivit(string peli, int maara)
        {
            List<string> rivit = new List<string>();

            for (int i = 0; i < maara; i++)
            {
                string rivi = string.Empty;

                switch (peli)
                {
                    case "Lotto":
                        rivi = ArvoLottoRivi();
                        break;

                    case "Viking Lotto":
                        rivi = ArvoVikingLottoRivi();
                        break;

                    case "Eurojackpot":
                        rivi = ArvoEurojackpotRivi();
                        break;

                    default:
                        break;
                }

                rivit.Add(rivi);
            }

            return rivit;
        }

        private string ArvoLottoRivi()
        {
            List<int> numerot = Enumerable.Range(1, 39).ToList();
            numerot = numerot.OrderBy(x => random.Next()).Take(7).ToList();

            return string.Join(", ", numerot);
        }

        private string ArvoVikingLottoRivi()
        {
            List<int> numerot = Enumerable.Range(1, 48).ToList();
            numerot = numerot.OrderBy(x => random.Next()).Take(6).ToList();

            return string.Join(", ", numerot);
        }

        private string ArvoEurojackpotRivi()
        {
            List<int> numerot = Enumerable.Range(1, 50).ToList();
            numerot = numerot.OrderBy(x => random.Next()).Take(5).ToList();

            List<int> tähtinumerot = Enumerable.Range(1, 10).ToList();
            tähtinumerot = tähtinumerot.OrderBy(x => random.Next()).Take(2).ToList();

            return $"Numerot: {string.Join(", ", numerot)}\nTähtinumerot: {string.Join(", ", tähtinumerot)}";
        }

        private int TarkastaRivi(string peli, string rivi)
        {
            int oikeatNumerot = 0;

            switch (peli)
            {
                case "Lotto":
                    oikeatNumerot = TarkastaLottoRivi(rivi);
                    break;

                case "Viking Lotto":
                    oikeatNumerot = TarkastaVikingLottoRivi(rivi);
                    break;

                case "Eurojackpot":
                    oikeatNumerot = TarkastaEurojackpotRivi(rivi);
                    break;

                default:
                    break;
            }

            return oikeatNumerot;
        }

        private int TarkastaLottoRivi(string rivi)
        {
            return random.Next(8);
        }

        private int TarkastaVikingLottoRivi(string rivi)
        {
            return random.Next(7);
        }

        private int TarkastaEurojackpotRivi(string rivi)
        {
            return random.Next(10);
        }
    }
}
