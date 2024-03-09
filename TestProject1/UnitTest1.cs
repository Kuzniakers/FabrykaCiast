using NUnit.Framework;
using System.Linq;
using Programowanie_zaawansowane_09._03_Ku�niak_Konrad;

namespace TestProject1
{
    public class Tests
    {
        // w tym prostym te�cie zastosowa�em wzorzec testowy AAA (Arrange - Act - Assert)

        [Test]
        public void DodajCiasto_CiastoCzekoladowe_DodaneDoPlanu()
        {
          
            var fabryka = new FabrykaCiastaCzekoladowego();
            var planPieczenia = new PlanPieczenia();

            
            planPieczenia.DodajCiasto(fabryka);

          
            Assert.IsTrue(planPieczenia.Any(), "Plan pieczenia powinien zawiera� przynajmniej jedno ciasto po dodaniu.");

            var ciasto = planPieczenia.FirstOrDefault();
            Assert.IsNotNull(ciasto, "Dodane ciasto nie powinno by� null.");
            Assert.AreEqual("Czekoladowe", ciasto.Nazwa, "Nazwa dodanego ciasta powinna by� 'Czekoladowe'.");
            Assert.AreEqual("Kruche", ciasto.Rodzaj, "Rodzaj dodanego ciasta powinien by� 'Kruche'.");
            CollectionAssert.Contains(ciasto.Skladniki, "Czekolada", "W sk�adnikach dodanego ciasta powinna znajdowa� si� 'Czekolada'.");
        }
    }
}
