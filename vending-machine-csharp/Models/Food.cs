namespace vending_machine_csharp.Models
{
  public class Food : Product
  {
    public int Ounces { get; set; }
    public Food(string location, int quantity, string name, decimal price, int oz) : base(price, name, quantity, location)
    {
      Ounces = oz;
    }
  }
}