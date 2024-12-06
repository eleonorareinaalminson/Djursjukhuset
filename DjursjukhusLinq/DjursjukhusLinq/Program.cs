namespace DjursjukhusLinq;

internal class Program
{
    static void Main(string[] args)
    {
        var animals = new List<Animal>
        {            
            new Animal("Hank", "Hund", 1, 4, false),
            new Animal("Gizmo", "Hund", 5, 4, true),
            new Animal("Billie", "Katt", 13, 4, true),
            new Animal("Bob", "Hund", 7, 4, true),
            new Animal("Mio", "Katt", 4, 4, true),            
            new Animal("Shadow", "Papegoja", 9, 2, false),
            new Animal("Charles", "Kanin", 2, 4, false),
            new Animal("Athena", "Katt", 4, 4, true),
            new Animal("Ozzy", "Hund", 6, 4, true),
            new Animal("Teddy", "Kanin", 1, 4, true),           
            new Animal("Karl", "Hund", 2, 4, false)

        };


        int dogCount = animals
            .Count(a => a.Species == "Hund");
        Console.WriteLine($"Antal hundar på djursjukhuset: {dogCount}");

        var oldestAnimal = animals
            .OrderByDescending(a => a.Age)
            .First();
        Console.WriteLine($"\nDet äldsta djuret är: {oldestAnimal.Name} ({oldestAnimal.Species}), {oldestAnimal.Age} år");


        var vaccinatedAnimals = animals
            .Where(a => a.IsVaccinated)
            .Select(a => $"{a.Name} ({a.Species})");

        Console.WriteLine("\nAlla djur som är vaccinerade:");
        Console.WriteLine(string.Join("\n", vaccinatedAnimals));

        var fourLegsOverThree = animals
            .Where(a => a.Legs == 4 && a.Age > 3)
            .Select(a => $"{a.Name} ({a.Species}), {a.Age} år");
        Console.WriteLine("\nFyrbenta djur som är äldre än 3 år:");
        Console.WriteLine(string.Join("\n", fourLegsOverThree));

        bool animalCalledShadow = animals
            .Any(a => a.Name == "Shadow");
        Console.WriteLine($"\nNågot inneliggande djur med namn Shadow? {(animalCalledShadow ? "Ja" : "Nej")}");
    


    }
}

