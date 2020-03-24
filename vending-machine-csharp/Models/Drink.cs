namespace vending_machine_csharp.Models
{
  public class Drink : Product
  {
    public int FluidOunces { get; set; }
    public Drink(string location, int quantity, string name, decimal price, int oz) : base(price, name, quantity, location)
    {
      FluidOunces = oz;
    }
  }
}