using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication35
{
    class Pacjent:Osoba
    {
        private int wiek;

        public Pacjent(string imie, string nazwisko, int wiek)
            //:base(imie, nazwisko)
        {
            this.wiek = wiek;
            UstawImie(imie);
            UstawNazwisko(nazwisko);
        }
    }
}
