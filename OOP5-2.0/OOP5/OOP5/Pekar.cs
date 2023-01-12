using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Pekar : Zamestnanec
    {
        int pocethodinvnoci = 0;
        public Pekar(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda, DateTime datumNarozeni) : base(jmeno, prijmeni, datumNastupu, hodinovaMzda, datumNarozeni)
        {
            
        }

        public void OdporacujHodiny(int hodiny, int hodinyvnoci)
        {
            odpracHodiny += hodiny;
            pocethodinvnoci += hodinyvnoci;
        }

        public override int VypoctiMzdu()
        {
            return HodinovaMzda * odpracHodiny + HodinovaMzda * pocethodinvnoci * 2;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} \ns hodinovou mzdou: {2} \nVek: {3}\ns poctem dni od nastupu: {4}\n\nCelkova mzda: {5}", jmeno, prijmeni, HodinovaMzda, Vek(), PocetDni(), VypoctiMzdu());
        }

    }
}
