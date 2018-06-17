using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhaling_juni2015
{
    class Adres
    {
        public string Straat { get; set; }
        public int Huisnummer { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }

        public Adres(string straat, int huisnr, int postcode, string gemeente)
        {
            Straat = straat;
            Huisnummer = huisnr;
            Postcode = postcode;
            Gemeente = gemeente;
        }

        public override string ToString()
        {
            string output = Straat + " " + Huisnummer;
            output += "/n" + Postcode + " " + Gemeente;


            return output; 
        }
    }
}
