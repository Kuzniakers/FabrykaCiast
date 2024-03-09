using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie_zaawansowane_09._03_Kuźniak_Konrad
{
    using System; 
    using System.Collections; 
    using System.Collections.Generic; 

    public class PlanPieczenia : IEnumerable<Ciasto>
    {
        private List<Ciasto> plan = new List<Ciasto>();

        public void DodajCiasto(IFabrykaCiasta fabryka)
        {
            plan.Add(fabryka.StworzCiasto());
        }

      
        public IEnumerator<Ciasto> GetEnumerator()
        {
            return plan.GetEnumerator();
        }

        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator(); 
        }

        public void WyswietlPlan()
        {
            foreach (var ciasto in plan)
            {
                Console.WriteLine($"Nazwa: {ciasto.Nazwa}, Rodzaj: {ciasto.Rodzaj}, Składniki: {string.Join(", ", ciasto.Skladniki)}");
            }
        }
    }

}
