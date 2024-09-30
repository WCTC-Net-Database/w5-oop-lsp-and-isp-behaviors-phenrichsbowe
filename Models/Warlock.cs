using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models;

public class Warlock(string Name) : IEntity, ICastable
{
  public string Name { get; set; } = Name;

  public void Attack(IEntity entity)
  {
    Console.WriteLine($"{Name} attacks {entity.Name}");
  }

  public void Move()
  {
    Console.WriteLine($"{Name} moves forward by creating a rift between dimensions!");
  }

  public void Cast(string spellName)
  {

    switch (spellName)
    {
      case "healing":
        Console.WriteLine($"{Name} casts a healing spell brining them back up to full health!");
        break;
      case "protection":
        Console.WriteLine($"{Name} casts a protection spell making them resistent to heavy attacks.");
        break;
      default:
        Console.WriteLine($"{Name} gets confused and attacks themselves");
        break;
    }
  }
}