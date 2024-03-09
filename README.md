# System Zarządzania Planem Pieczenia Ciast 

Projekt wykonany w ramach praktycznych zajęć programowania zaawansowanego w języku C# na studiach. 

## Wykonał

Konrad Kuźniak

## Rozpoczęcie pracy

Aby uruchomić projekt, potrzebujesz Visual Studio (lub innego IDE obsługującego C#) oraz .NET 5.0 (tak, archaiczna wersja która była dostępna na IDE uniwesyteckiego komputera)

### Instalacja programu

1. Sklonuj repozytorium na swój lokalny komputer.
   
2. Otwórz program w Visual Studio.

3. Projekt gotowy do uploadowania nowych pozycji.

## Struktura projektu

Projekt składa się z kilku kluczowych klas:

- `Ciasto`: Reprezentuje ciasto z nazwą, rodzajem i listą składników.
- `IFabrykaCiasta`: Interfejs dla fabryk ciast.
- `FabrykaCiastaCzekoladowego` / `FabrykaCiastaJablkowego`: Implementacje fabryk ciast.
- `PlanPieczenia`: Główna klasa zarządzająca planem pieczenia ciast.

## Przykład użycia

Poniższy przykład pokazuje, jak dodać ciasto czekoladowe i jabłkowe do planu pieczenia oraz jak wyświetlić plan:

```csharp
var planPieczenia = new PlanPieczenia();
planPieczenia.DodajCiasto(new FabrykaCiastaCzekoladowego());
planPieczenia.DodajCiasto(new FabrykaCiastaJablkowego());

planPieczenia.WyswietlPlan();


