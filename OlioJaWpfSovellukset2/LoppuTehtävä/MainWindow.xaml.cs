using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoppuTehtävä
{
    public abstract class Henkilo
    {
        public string Nimi { get; set; }
        public int Ika { get; set; }

        public Henkilo(string nimi, int ika)
        {
            Nimi = nimi;
            Ika = ika;
        }

        public abstract string GetTiedot();
    }

    public class Opiskelija : Henkilo
    {
        public string OpiskelijaNumero { get; set; }

        public Opiskelija(string nimi, int ika, string opiskelijaNumero)
            : base(nimi, ika)
        {
            OpiskelijaNumero = opiskelijaNumero;
        }

        public override string GetTiedot()
        {
            return $"Opiskelija: {Nimi}, Ikä: {Ika}, Opiskelijanumero: {OpiskelijaNumero}";
        }
    }

    public class HenkiloHallinta
    {
        private ObservableCollection<Henkilo> henkilot;

        public HenkiloHallinta()
        {
            henkilot = new ObservableCollection<Henkilo>();
        }

        public void LisaaHenkilo(Henkilo henkilo)
        {
            henkilot.Add(henkilo);
        }

        public void TallennaTiedostoon(string tiedostoPolku)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(tiedostoPolku))
                {
                    foreach (var henkilo in henkilot)
                    {
                        sw.WriteLine(henkilo.GetTiedot());
                    }
                }

                MessageBox.Show("Henkilöt tallennettu onnistuneesti.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tallennettaessa tiedostoa: {ex.Message}");
            }
        }
    }

    public partial class MainWindow : Window
    {
        private HenkiloHallinta henkiloHallinta;

        public MainWindow()
        {
            InitializeComponent();
            henkiloHallinta = new HenkiloHallinta();
        }

        private void LisaaHenkiloButton_Click(object sender, RoutedEventArgs e)
        {
            string nimi = NimiTextBox.Text;
            int ika = int.Parse(IkaTextBox.Text);
            string opiskelijaNumero = OpiskelijaNumeroTextBox.Text;

            Henkilo henkilo;

            if (string.IsNullOrWhiteSpace(opiskelijaNumero))
            {
                henkilo = new Henkilo(nimi, ika);
            }
            else
            {
                henkilo = new Opiskelija(nimi, ika, opiskelijaNumero);
            }

            henkiloHallinta.LisaaHenkilo(henkilo);
            PäivitaHenkiloLista();
        }

        private void TallennaTiedostoButton_Click(object sender, RoutedEventArgs e)
        {
            henkiloHallinta.TallennaTiedostoon("henkilot.txt");
        }

        private void PäivitaHenkiloLista()
        {
            HenkiloListBox.ItemsSource = henkiloHallinta.Henkilot;
        }
    }
}