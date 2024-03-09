using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie_zaawansowane_09._03_Kuźniak_Konrad
{
    public class Ciasto
    {
        // zastosowałem użycie getterów i setterów dla wymaganych stringów
        public string Nazwa { get; set; }
        public string Rodzaj { get; set; }
        public List<string> Skladniki { get; set; }
    }

}
