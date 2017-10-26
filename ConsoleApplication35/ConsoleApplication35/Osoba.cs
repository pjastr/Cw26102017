using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Osoba
    {
        private string imie;
        private string nazwisko;

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public void UstawImie(string imie)
        {
            this.imie = imie;
        }
        public void UstawNazwisko(string nazwisko)
        {
            this.nazwisko = nazwisko;
        }

        public Osoba()
        {

        }
    }
}
