using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Vedouci : Zamestnanec
    {
        int priplatekZaVedeni;
        string titul;

        public Vedouci(int priplatekZaVedeni, string titul, string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda, DateTime datumNarozeni) : base(jmeno, prijmeni, datumNastupu, hodinovaMzda, datumNarozeni)
        {
            this.priplatekZaVedeni = priplatekZaVedeni;
            this.titul = titul;
            base.jmeno = titul + " " + jmeno;
        }
        
        public override int VypoctiMzdu()
        {           
            return HodinovaMzda * odpracHodiny + priplatekZaVedeni;
        }

    }
}
