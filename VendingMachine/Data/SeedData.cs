using VendingMachine.Models;

namespace VendingMachine.Data;

public static class SeedData
{
    public static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new("Coke", 20),
            new("Chips", 15),
            new("Chocolate", 10)
        };
    }
}