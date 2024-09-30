using W5_assignment_template.Interfaces;

namespace W5_assignment_template.Models
{
    public class Ghost(string Name) : IEntity, IFlyable
    {
        private FlyAction? _flyAction;
        public string Name { get; set; } = Name;

        public void Attack(IEntity entity)
        {
            Console.WriteLine($"{Name} attacks {entity.Name} with a chilling touch.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} floats silently.");
        }

        public void SetFlyAction(FlyAction flyAction) {
            _flyAction = flyAction;
        }

        public void Fly()
        {
            _flyAction?.Invoke(Name);
        }
    }
}
