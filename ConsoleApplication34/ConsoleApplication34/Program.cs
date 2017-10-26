using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication34
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student student1 = new Student("jan", "kowalski", 1990, 1, 4, 89234);
            //Console.WriteLine(student1.ObliczWiek());
            //student1.UstawMiejsceZamieszkania("Olsztyn");

            //Osoba student2 = new Student();
            //student2.WypiszInfo();

            Student student3 = new Student();
            Osoba osoba3 = student3;
            Student student4 = osoba3;
            student4.WypiszInfo();
            Console.ReadKey();
        }
    }
}
