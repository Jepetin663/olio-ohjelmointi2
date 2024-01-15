using System;
using System.Collections.Generic;
using System.Windows;

namespace OpiskelijaSovellus
{
    public partial class MainWindow : Window
    {
        private Dictionary<string, Opiskelija> opiskelijat = new Dictionary<string, Opiskelija>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LisaaOpiskelijaButton_Click(object sender, RoutedEventArgs e)
        {
            string etunimi = EtunimiTextBox.Text;
            string sukunimi = SukunimiTextBox.Text;
            string ryhmaTunnus = "ABC123";
            string opiskelijaID = GetUniqueOpiskelijaID();

            try
            {
                Opiskelija uusiOpiskelija = new Opiskelija(etunimi, sukunimi, ryhmaTunnus, opiskelijaID);
                opiskelijat.Add(opiskelijaID, uusiOpiskelija);
                PaivitaOpiskelijaLista();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Virhe: {ex.Message}");
            }
        }

        private void PoistaOpiskelijaButton_Click(object sender, RoutedEventArgs e)
        {
            string poistettavaID = GetOpiskelijaID();

            if (opiskelijat.ContainsKey(poistettavaID))
            {
                opiskelijat.Remove(poistettavaID);
                PaivitaOpiskelijaLista();
            }
            else
            {
                MessageBox.Show("OpiskelijaID:tä ei löytynyt. Tarkista ID ja yritä uudelleen.");
            }
        }

        private void TulostaOpiskelijatButton_Click(object sender, RoutedEventArgs e)
        {
            PaivitaOpisk
