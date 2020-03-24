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

    void ListAvailableProducts();

    void AddProduct(Product productToAdd);
  }
}