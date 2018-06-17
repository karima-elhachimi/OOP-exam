using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_juni2015
{
    class Appartement : Woning
    {
        const decimal BELASTING = 0.6M;
        public int Verdiep { get; set; }

        public Appartement(Adres adres, int prijs, WijzeVerkoop wijze, int verdiep):base(adres, prijs, wijze)
        {
            Verdiep = verdiep;
        }
        public override decimal BerekenBelastingen()
        {
            return this._Prijs * BELASTING;
        }

        public override int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Appartement/n" + base.ToString()+"/nIs gelegen op de "+Verdiep+"de verdieping";
        }
    }
}
