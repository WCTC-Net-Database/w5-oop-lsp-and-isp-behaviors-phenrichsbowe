namespace W5_assignment_template.Interfaces;

public delegate void FlyAction(string entityName);
public interface IFlyable {
  public void SetFlyAction(FlyAction flyAction);
  public void Fly();
}