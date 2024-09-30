using W5_assignment_template.Interfaces;
using W5_assignment_template.Models;

namespace W5_assignment_template.Services
{
    public class GameEngine
    {
        private readonly Character _character;
        private readonly Goblin _goblin;
        private readonly Ghost _ghost;
        private readonly Archer _archer;
        private readonly Warlock _warlock;

        public GameEngine(Character character, Goblin goblin, Ghost ghost, Archer archer, Warlock warlock)
        {
            _character = character;
            
            _goblin = goblin;

            _ghost = ghost;
            _ghost.SetFlyAction(name => Console.WriteLine($"{name} flies through the air raipdly!"));

            _archer = archer;
            _warlock = warlock;
        }

        public void Run()
        {
            _character.Name = "Hero";
            _goblin.Name = "Goblin";
            _ghost.Name = "Ghost";

            _character.Move();
            _character.Attack(_goblin);

            _goblin.Move();
            _goblin.Attack(_character);

            _ghost.Move();
            _ghost.Attack(_character);

            if (_ghost is IFlyable) {
                _ghost.Fly();
            }

            _archer.Move();
            _archer.Attack(_goblin);

            if (_archer is IShootable) {
                _archer.Shoot();
            }

            _warlock.Move();
            _warlock.Attack(_ghost);

            if (_warlock is ICastable) {
                _warlock.Cast("healing");
                _warlock.Cast("protection");
            }
        }
    }
}
