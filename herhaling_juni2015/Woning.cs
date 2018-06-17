using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_juni2015
{
    public enum WijzeVerkoop { Nieuwbouw, Registratie}
    abstract class Woning: IBerekeningen
    {
        const decimal BTW = 1.21M;
        const decimal REGISTRATIEKOST = 1.10M;
        public Adres _Adres { get; set; }
        public int _Prijs { get; set; }
        public WijzeVerkoop _Wijze { get; set; }

        public Woning(Adres adres, int prijs, WijzeVerkoop wijze)
        {
            _Adres = adres;
            _Prijs = prijs;
            _Wijze = wijze;
        }

        public decimal BerekenTotaal()
        {
            decimal totaal = 0;
            if (_Wijze == WijzeVerkoop.Nieuwbouw)
            {
                totaal = _Prijs * BTW;
            }
            else if(_Wijze == WijzeVerkoop.Registratie)
            {
                totaal = _Prijs * REGISTRATIEKOST;
            }

            return totaal;
        }

        public abstract decimal BerekenBelastingen();


        public abstract int CompareTo(object obj);

        public override string ToString()
        {

            return _Adres.ToString() + " kost " + _Prijs + " wordt verkocht met " + _Wijze;
        }

    }
}
