using NUnit.Framework;
using System.Linq;
using Programowanie_zaawansowane_09._03_KuŸniak_Konrad;

namespace TestProject1
{
    public class Tests
    {
        // w tym prostym teœcie zastosowa³em wzorzec testowy AAA (Arrange - Act - Assert)

        [Test]
        public void DodajCiasto_CiastoCzekoladowe_DodaneDoPlanu()
        {
          
            var fabryka = new FabrykaCiastaCzekoladowego();
            var planPieczenia = new PlanPieczenia();

            
            planPieczenia.DodajCiasto(fabryka);

          
            Assert.IsTrue(planPieczenia.Any(), "Plan pieczenia powinien zawieraæ przynajmniej jedno ciasto po dodaniu.");

            var ciasto = planPieczenia.FirstOrDefault();
            Assert.IsNotNull(ciasto, "Dodane ciasto nie powinno byæ null.");
            Assert.AreEqual("Czekoladowe", ciasto.Nazwa, "Nazwa dodanego ciasta powinna byæ 'Czekoladowe'.");
            Assert.AreEqual("Kruche", ciasto.Rodzaj, "Rodzaj dodanego ciasta powinien byæ 'Kruche'.");
            CollectionAssert.Contains(ciasto.Skladniki, "Czekolada", "W sk³adnikach dodanego ciasta powinna znajdowaæ siê 'Czekolada'.");
        }
    }
}
