using System;

namespace Programowanie_zaawansowane_09._03_Kuźniak_Konrad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var planPieczenia = new PlanPieczenia();
            planPieczenia.DodajCiasto(new FabrykaCiastaCzekoladowego());
            planPieczenia.DodajCiasto(new FabrykaCiastaJablkowego());

            foreach (var ciasto in planPieczenia)
            {
                Console.WriteLine($"Nazwa: {ciasto.Nazwa}, Rodzaj: {ciasto.Rodzaj}, Składniki: {string.Join(", ", ciasto.Skladniki)}");
            }
            Console.WriteLine();
            Console.WriteLine("Aby wyłaczyć program naciśnij dowolny przycisk");
        }
    }

}
