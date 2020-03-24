using System.Collections.Generic;
using vending_machine_csharp.Models;

namespace vending_machine_csharp.Interfaces
{
  public interface IVendingMachine
  {
    decimal TransactionBalance { get; set; }
    decimal TotalBalance { get; set; }
    List<Product> Products { get; set; }

    void AddMoney(decimal amount);
    //NOTE Interfaces don't define what the logic within the methods do. They only specify that there must be a method on the implementing Class with that name

    void ListAvailableProducts();

    void AddProduct(Product productToAdd);
  }
}