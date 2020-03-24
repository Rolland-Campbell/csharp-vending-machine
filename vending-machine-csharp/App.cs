using System;

namespace vending_machine_csharp
{
  public class App
  {
    public VendingMachine vendingMachine { get; set; }
    Boolean active = true;
    public void Setup()
    {
    }
    public void Run()
    {
      System.Console.WriteLine("Welcome to my vending machine");
      while (active)
      {
        Menu();
      }
    }

    public void Menu()
    {
      Console.WriteLine("What would you like to purchase?\n\r1) View Products \n\r2) Purchase\n\r3) Add a Quarter\n\r4) Leave");

      string userInput = Console.ReadLine();
      switch (userInput)
      {
        case "1":
          vendingMachine.ListAvailableProducts();
          break;
        case "2":
          vendingMachine.PurchaseProduct();
          break;
        case "3":
          vendingMachine.AddMoney(0.25m);
          break;
        case "4":
          active = false;
          break;
        default:
          Console.WriteLine("Invalid Selection");
          break;
      }
    }
  }
}