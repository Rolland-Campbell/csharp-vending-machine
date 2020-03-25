using System;
using System.Collections.Generic;
using vending_machine_csharp.Interfaces;

namespace vending_machine_csharp.Models
{
  public class VendingMachine : IVendingMachine
  //NOTE You do not need an interface, it will work without it. 
  {
    public decimal TransactionBalance { get; set; }
    public decimal TotalBalance { get; set; }
    public List<Product> Products { get; set; }

    public void AddMoney(decimal amount)
    {
      Console.Clear();
      TransactionBalance += amount;
      Console.WriteLine($"your current balance is {TransactionBalance}");
    }

    public void ListAvailableProducts()
    {
      Console.Clear();
      foreach (var item in Products)
      {
        if (item.Available)
        {
          Console.WriteLine($"Location: {item.Location} Item: {item.Name}  Price: ${item.Price} Quantity: {item.Quantity}");
        }
      }
      Console.WriteLine("Press Enter to continue.");
      Console.ReadLine();
    }

    public void AddProduct(Product productToAdd)
    {
      Products.Add(productToAdd);
    }

    public VendingMachine(decimal total)
    {
      TransactionBalance = 0;
      TotalBalance = total;
      Products = new List<Product>();
    }

    public void PurchaseProduct()
    {
      Console.WriteLine("Enter location:");
      string userChoice = Console.ReadLine();
      Product productToPurchase = Products.Find(p => p.Location == userChoice.ToUpper());
      //did they choose a correct location
      if (productToPurchase == null)
      {
        System.Console.WriteLine("Invalid location, please try again.");
      }
      else
      {
        //do they have enough money?
        if (TransactionBalance < productToPurchase.Price)
        {
          System.Console.WriteLine("Insufficient funds");
          return;
        }
        //is the product in the machine?
        if (!productToPurchase.Available)
        {
          System.Console.WriteLine("Product not available");
          return;
        }
        //if they have enough money and the product is there, perform purchase.
        TransactionBalance -= productToPurchase.Price;
        productToPurchase.Quantity--;

        TotalBalance += productToPurchase.Price;
        System.Console.WriteLine($"Thank you for your purchase, Enjoy your {productToPurchase.Name}");
      }
    }
  }
}