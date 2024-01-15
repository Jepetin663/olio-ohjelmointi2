using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfSovellus
{
    public partial class MainWindow : Window
    {
        private TehtavaHallinta tehtavaHallinta;

        public MainWindow()
        {
            InitializeComponent();
            tehtavaHallinta = new TehtavaHallinta();
        }

        private void LisaaTehtavaButton_Click(object sender, RoutedEventArgs e)
        {
            string kuvaus = DescriptionTextBox.Text;
            string tarkkuus = ((ComboBoxItem)PriorityComboBox.SelectedItem)?.Content.ToString();

            Tehtava tehtava;

            if (tarkkuus == "Tärkeä")
            {
                tehtava = new TarkeaTehtava(kuvaus);
            }
            else
            {
                tehtava = new TavallinenTehtava(kuvaus);
            }

            tehtavaHallinta.LisaaTehtava(tehtava);
            PaivitaTehtavalista();
        }

        private void PaivitaTehtavalista()
        {
            TaskListBox.ItemsSource = tehtavaHallinta.Tehtavat;
        }
    }
}
