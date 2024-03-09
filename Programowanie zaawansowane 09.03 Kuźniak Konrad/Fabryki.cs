using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie_zaawansowane_09._03_Kuźniak_Konrad
{
    public class FabrykaCiastaCzekoladowego : IFabrykaCiasta
    {
        public Ciasto StworzCiasto()
        {
            return new Ciasto
            {
                Nazwa = "Czekoladowe",
                Rodzaj = "Kruche",
                Skladniki = new List<string> { "Czekolada", "Mąka", "Jajka", "Masło" }
            };
        }
    }

    public class FabrykaCiastaJablkowego : IFabrykaCiasta
    {
        public Ciasto StworzCiasto()
        {
            return new Ciasto
            {
                Nazwa = "Jabłkowe",
                Rodzaj = "Drożdżowe",
                Skladniki = new List<string> { "Jabłka", "Cynamon", "Mąka", "Cukier" }
            };
        }
    }

}
