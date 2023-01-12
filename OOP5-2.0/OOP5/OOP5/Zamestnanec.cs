using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Zamestnanec
    {
        protected string jmeno;
        protected string prijmeni;
        protected DateTime datumNastupu;
        protected DateTime datumNarozeni;
        protected int odpracHodiny;
        public int HodinovaMzda { get; }

        public Zamestnanec(string jmeno, string prijmeni, DateTime datumNastupu, int hodinovaMzda, DateTime datumNarozeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.datumNastupu = datumNastupu;
            this.HodinovaMzda = hodinovaMzda;
            this.datumNarozeni = datumNarozeni;
        }

        public double PocetDni()
        {
            return Math.Round((DateTime.Today - datumNastupu).TotalDays, 0);
        }

        public void OdporacujHodiny(int hodiny)
        {
            odpracHodiny += hodiny;
        }

        public virtual int VypoctiMzdu()
        {
            return HodinovaMzda * odpracHodiny;
        }
        
        public double Vek()
        {
            TimeSpan vek = DateTime.Today - datumNarozeni;
            return (Math.Floor((vek.TotalDays / 365.25)));            
        }

        public override string ToString()
        {
            //return String.Format("{0} {1} \ns hodinovou mzdou: {2} \ns poctem dni od nastupu: {3}\n\nCelkova mzda: {4}", jmeno, prijmeni, HodinovaMzda, PocetDni(), VypoctiMzdu());
            return String.Format("{0} {1} \ns hodinovou mzdou: {2} \nVek: {3}\ns poctem dni od nastupu: {4}\n\nCelkova mzda: {5}", jmeno, prijmeni,HodinovaMzda,Vek() , PocetDni(), VypoctiMzdu());
        }
    }
}