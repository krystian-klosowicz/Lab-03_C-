using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Student : IStudent
    {
        private string uczelnia;
        private string kierunek;
        private int rok;
        private string semestr;
        private string imie;
        private string nazwisko;

        public Student(string imie, string nazwisko, string uczelnia, string kierunek, int rok, string semestr)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.uczelnia = uczelnia;
            this.kierunek = kierunek;
            this.rok = rok;
            this.semestr = semestr;

        }

        public Student()
        {
        }



        public void setImie(string imie)
        {
            this.imie = imie;
        }

        public void setKierunek(string kierunek)
        {
            this.kierunek = kierunek; 
        }

        public void setNazwisko(string nazwisko)
        {
            this.nazwisko= nazwisko;
        }

        public void setRok(int rok)
        {
            this.rok = rok;
        }

        public void setSemestr(string semestr)
        {
            this.semestr = semestr;
        }

        public void setUczelnia(string uczelnia)
        {
            this.uczelnia=uczelnia;
        }

        public string ZwrocPelnaNazwe()
        {
            return imie + " " + nazwisko;
        }

        public string WypiszPelnaNazweIUczelnie()
        {
            return ZwrocPelnaNazwe() + " - " + kierunek + " " + rok + " " + semestr + " " + " " + uczelnia;
        }
    }
}
