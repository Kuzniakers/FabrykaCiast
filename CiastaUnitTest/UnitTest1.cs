using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;


namespace CiastaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
         
            var fabryka = new Fabryki(); 
            var planPieczenia = new PlanPieczenia(); 

   
            planPieczenia.DodajCiasto(fabryka); 
            var wynik = planPieczenia.GetEnumerator(); 

            
            Assert.IsTrue(wynik.MoveNext()); 
            var ciasto = wynik.Current;
            Assert.IsNotNull(ciasto); 
            Assert.AreEqual("Czekoladowe", ciasto.Nazwa); 
            Assert.AreEqual("Kruche", ciasto.Rodzaj); 
            CollectionAssert.AreEqual(new List<string> { "Czekolada", "Mąka", "Jajka", "Masło" }, ciasto.Skladniki); 
        }
    }
}
