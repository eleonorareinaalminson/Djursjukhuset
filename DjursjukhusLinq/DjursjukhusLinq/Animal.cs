using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjursjukhusLinq;

public class Animal
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public int Legs { get; set; }
    public bool IsVaccinated { get; set; }

    public Animal(string name, string species, int age, int legs, bool isVaccinated)
    {
        Name = name;
        Species = species;
        Age = age;
        Legs = legs;
        IsVaccinated = isVaccinated;
    }
}
