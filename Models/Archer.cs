using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
  public class Archer : IEntity, IShootable
  {
    public string Name { get; set; }

    public Archer(string name)
    {
      Name = name;
    }

    public void Shoot()
    {
      Console.WriteLine($"{Name} shoots a trifecta of flaming arrows!");
    }

    public void Attack(IEntity target)
    {
      Console.WriteLine($"{Name} attacks {target.Name} with an arrow!");
    }

    public void Move()
    {
      Console.WriteLine($"{Name} moves stealthily through the forest.");
    }
  }
}
