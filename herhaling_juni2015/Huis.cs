using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_juni2015
{
    public enum Bebouwingen { Open, Halfopen, Gesloten};
    class Huis : Woning
    {
        const decimal BELASTING = 0.8M;
        public Bebouwingen Bebouwing { get; set; }

        public Huis(Adres adres, int prijs, WijzeVerkoop wijze, Bebouwingen bebouwing):base(adres, prijs, wijze)
        {
            this.Bebouwing = bebouwing;
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
            return "Huis " + Bebouwing + " bebouwing/n" + base.ToString();
        }
    }
}
