using System;
using System.Collections.ObjectModel;
using System.IO;

namespace WpfSovellus
{
    public class TehtavaHallinta
    {
        private ObservableCollection<Tehtava> tehtavat;

        public ObservableCollection<Tehtava> Tehtavat => tehtavat;

        public TehtavaHallinta()
        {
            tehtavat = new ObservableCollection<Tehtava>();
        }

        public void LisaaTehtava(Tehtava tehtava)
        {
            tehtavat.Add(tehtava);
        }

        public void TallennaTiedostoon(string tiedostoPolku)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(tiedostoPolku))
                {
                    foreach (var tehtava in tehtavat)
                    {
                        sw.WriteLine(tehtava.GetTiedot());
                    }
                }

                Console.WriteLine("Tehtävät tallennettu onnistuneesti.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Virhe tallennettaessa tiedostoa: {ex.Message}");
            }
        }
    }
}
