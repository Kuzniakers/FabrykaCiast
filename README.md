# Cake Baking Schedule Management System

This project was developed as part of the advanced programming course in C# during university studies.

## Author

Konrad Kuźniak

## Getting Started

To run the project, you need Visual Studio (or another IDE that supports C#) and .NET 5.0 (yes, an outdated version that was available on the university's computer IDE).

### Installation

1. Clone the repository to your local machine.

2. Open the project in Visual Studio.

3. The project is ready to upload new entries.

---

## Project Structure

The project consists of several key classes:

- `Cake`: Represents a cake with a name, type, and a list of ingredients.
- `ICakeFactory`: Interface for cake factories.
- `ChocolateCakeFactory` / `AppleCakeFactory`: Implementations of the cake factories.
- `BakingSchedule`: The main class that manages the cake baking schedule.

---

## Usage Example

The following example demonstrates how to add a chocolate cake and an apple cake to the baking schedule and display the schedule:

```csharp
var bakingSchedule = new BakingSchedule();
bakingSchedule.AddCake(new ChocolateCakeFactory());
bakingSchedule.AddCake(new AppleCakeFactory());

bakingSchedule.DisplaySchedule();
