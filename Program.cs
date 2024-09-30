using W5_assignment_template.Models;
using W5_assignment_template.Services;

namespace W5_assignment_template
{
    class Program
    {
        static void Main()
        {
            Character character = new("Hero");
            Goblin goblin = new("Goblin");
            Ghost ghost = new("Ghost");
            Archer archer = new("Archer");
            Warlock warlock = new("Warlock");

            GameEngine gameEngine = new(character, goblin, ghost, archer, warlock);
            gameEngine?.Run();
        }

    }
}
