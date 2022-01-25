using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public interface IStudent : IOsoba
    {
        void setUczelnia(String uczelnia);
        void setKierunek(String kierunek);
        void setRok(int rok);

        void setSemestr(String semestr);
        void setImie(String imie);
        void setNazwisko(String nazwisko);
        String ZwrocPelnaNazwe();
    }
}
