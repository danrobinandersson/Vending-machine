using VendingMachine.Models;

namespace VendingMachine.Data;

public static class SeedData
{
    public static List<Product> GetProducts()
    {
        return new List<Product>
        {
            new("Kebabrulle", 45),
            new("Kebab med bröd", 40),
            new("Kebabpizza", 70),
            new("Kebabtallrik", 59),
            new("Falafelrulle", 42)
        };
    }
}