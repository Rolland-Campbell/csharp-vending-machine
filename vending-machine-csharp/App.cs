using System;
using vending_machine_csharp.Models;

namespace vending_machine_csharp
{
  public class App
  {
    public VendingMachine vendingMachine { get; set; }
    Boolean active = true;
    public void Setup()
    {
      Food doritoz = new Food("A1", 10, "Doritoz", 2.0m, 8);
      Food oreos = new Food("A2", 10, "Oreos", 2.0m, 8);
      Food tp = new Food("A3", 10, "Fluffy Bunny", 500.0m, 10);
      Drink sprite = new Drink("B1", 7, "Sprite", 1.50m, 20);
      Drink tea = new Drink("B2", 7, "Yerba Mate", 3.50m, 12);
      Drink oj = new Drink("B3", 7, "Orange Juice", 2.00m, 16);

      vendingMachine = new VendingMachine(25.00m);

      vendingMachine.AddProduct(doritoz);
      vendingMachine.AddProduct(oreos);
      vendingMachine.AddProduct(tp);
      vendingMachine.AddProduct(sprite);
      vendingMachine.AddProduct(tea);
      vendingMachine.AddProduct(oj);

      Run();
    }
    public void Run()
    {
      System.Console.WriteLine(@"
       ________________________________________
       |                                      |
       |   ______________________             |
       |  |   __    __    __    |             |
       |  |  |  |  |  |  |  |   | ___________ |
       |  |  |__|  |__|  |__|   | |         | |
       |  |   __    __    __    | | @@   @@ | |
       |  |  |  |  |  |  |  |   | |         | |
       |  |  |__|  |__|  |__|   | | @@   @@ | |
       |  |   __    __    __    | |         | |
       |  |  |  |  |  |  |  |   | | @@   @@ | |
       |  |  |__|  |__|  |__|   | |         | |
       |  |   __    __    __    | | @@   @@ | |
       |  |  |  |  |  |  |  |   | |_________| |
       |  |  |__|  |__|  |__|   |             |
       |  |   __    __    __    |             |
       |  |  |  |  |  |  |  |   |             |
       |  |  |__|  |__|  |__|   |             |
       |  |                     |             |
       |  |_____________________|             |
       |  _________________________           |
       |  |        P U S H        |           |
       |  |_______________________|           |
       |______________________________________|
       ||                                    ||

Welcome to my vending machine");
      while (active)
      {
        Menu();
      }
    }

    public void Menu()
    {
      Console.WriteLine("What would you like to purchase? \n\n\r1) View Products \n\r2) Purchase\n\r3) Add a Quarter\n\r4) Leave");

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