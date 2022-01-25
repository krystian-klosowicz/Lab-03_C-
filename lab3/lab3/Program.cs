using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> lista_osob = new List<Osoba>();
            Osoba o1 = new Osoba("Kamil", "Stoch");
            Osoba o2 = new Osoba("Adam", "Małysz");
            lista_osob.Add(o1);
            lista_osob.Add(o2);
            Console.WriteLine("Lista osób: ");
            lista_osob.WypiszOsoby();
            lista_osob.PosortujOsobyPoNazwisku();
            Console.WriteLine("Lista osób po posortowaniu: ");
            lista_osob.WypiszOsoby();
            Student s1 = new Student("Robert", "Lewandowski", "URZ", "AWF", 3, "drugi");
            Console.WriteLine(s1.WypiszPelnaNazweIUczelnie());
        }
    }
}
