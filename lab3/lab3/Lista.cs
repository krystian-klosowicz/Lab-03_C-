using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    static class Lista
    {
        public static void WypiszOsoby(this List<Osoba> lista)
        {
            foreach(Osoba osoba in lista)
            {
                Console.WriteLine(osoba.ZwrocPelnaNazwe());
            }
        }

        public static void PosortujOsobyPoNazwisku(this List<Osoba> lista)
        {
            lista.Sort((a, b) => a.getNazwisko().CompareTo(b.getNazwisko()));
        }
    }
}
