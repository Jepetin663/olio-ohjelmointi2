using System;
using System.Collections.Generic;
using System.IO;

namespace WpfSovellus
{
    public abstract class Tehtava
    {
        public string Kuvaus { get; set; }

        public Tehtava(string kuvaus)
        {
            Kuvaus = kuvaus;
        }

        public abstract string GetTiedot();
    }

    public class TavallinenTehtava : Tehtava
    {
        public TavallinenTehtava(string kuvaus)
            : base(kuvaus)
        {
        }

        public override string GetTiedot()
        {
            return $"Tavallinen tehtävä: {Kuvaus}";
        }
    }

    public class TarkeaTehtava : Tehtava
    {
        public TarkeaTehtava(string kuvaus)
            : base(kuvaus)
        {
        }

        public override string GetTiedot()
        {
            return $"Tärkeä tehtävä: {Kuvaus}";
        }
    }
}
