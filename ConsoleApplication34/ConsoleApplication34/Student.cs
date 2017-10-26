using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Student : Osoba
    {
        private int rok;
        private int nrGrupy;
        private int nrAlbumu;

        public Student()
        {

        }

        public Student(string imie, string nazwisko, int rokUrodzenia, int rok, int nrGrupy, int nrAlbumu)
            :base(imie, nazwisko,rokUrodzenia)
        {
            this.rok = rok;
            this.nrGrupy = nrGrupy;
            this.nrAlbumu = nrAlbumu;
        }

        public void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok studiów: {0}", rok);
            Console.WriteLine("Nr grupy: {0}", nrGrupy);
            Console.WriteLine("Nr albumu: {0}", nrAlbumu);
        }
    }
}
