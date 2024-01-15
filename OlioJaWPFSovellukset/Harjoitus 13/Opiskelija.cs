using System;

namespace OpiskelijaSovellus
{
    public class Opiskelija
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string RyhmaTunnus { get; set; }
        public string OpiskelijaID { get; set; }

        public Opiskelija(string etunimi, string sukunimi, string ryhmaTunnus, string opiskelijaID)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            RyhmaTunnus = ryhmaTunnus;

            if (string.IsNullOrEmpty(opiskelijaID))
            {
                throw new ArgumentException("OpiskelijaID ei voi olla tyhjä.");
            }

            OpiskelijaID = opiskelijaID;
        }

        public override string ToString()
        {
            return $"Opiskelija: {Etunimi} {Sukunimi}, Ryhmä: {RyhmaTunnus}, OpiskelijaID: {OpiskelijaID}";
        }
    }
}
