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
            new("Kebabpizza", 59),
            new("Kebabtallrik", 49),
            new("Falafelrulle", 42)
        };
    }
}