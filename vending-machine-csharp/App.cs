using System;
using vending_machine_csharp.Models;

namespace vending_machine_csharp
{
  public class App
  {
    public VendingMachine vendingMachine { get; set; }

    //setting the bool to true so program will run.
    Boolean active = true;
    public void Setup()
    {
      //creating items for the vending machine.
      Food doritoz = new Food("A1", 10, "Doritoz", 2.0m, 8);
      Food oreos = new Food("A2", 10, "Oreos", 2.0m, 8);
      Food tp = new Food("A3", 1, "Fluffy Bunny Toilet Paper", 500.0m, 10);
      Drink sprite = new Drink("B1", 10, "Sprite", 1.50m, 20);
      Drink tea = new Drink("B2", 10, "Lipton Unsweet Tea", 3.50m, 12);
      Drink oj = new Drink("B3", 10, "Orange Juice, White glove / Bronco edition", 2.00m, 16);

      vendingMachine = new VendingMachine(2.00m);

      //Adding items to the machine.
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
      System.Console.WriteLine("Welcome to my vending machine");
      while (active)
      {
        System.Console.WriteLine(@"
       ________________________________________
       |                                      |
       |   ______________________             |
       |  |   __    __    __    |             |
       |  |  |  |  |  |  |  |   | ___________ |
       |  |  |__|  |__|  |__|   | |         | |
       |  |   __    __    __    | | A1   A2 | |
       |  |  |  |  |  |  |  |   | |         | |
       |  |  |__|  |__|  |__|   | | A3   B1 | |
       |  |   __    __    __    | |         | |
       |  |  |  |  |  |  |  |   | | B2   B3 | |
       |  |  |__|  |__|  |__|   | |_________| |
       |  |   __    __    __    |             |
       |  |  |  |  |  |  |  |   |             |
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
       ");
        Menu();
      }
    }

    public void Menu()
    {
      Console.WriteLine(" \nWhat would you like to purchase? \n\n1) View Products \n2) Purchase\n3) Add a Quarter\n4) Remove Money\n5) Leave");

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
          vendingMachine.RemoveMoney();
          break;
        case "5":
          active = false;
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid Selection");
          break;
      }
    }
  }
}