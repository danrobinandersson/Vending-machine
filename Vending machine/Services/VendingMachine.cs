using Vending_machine.Models;

namespace Vending_machine.Services;

public class VendingMachine
{
    public List<Product> Products { get; set; } = new();

    public void ShowProducts()
    {
        for (int i = 0; i < Products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Products[i].Name} - {Products[i].Price} kr");
        }
    }

    public Product? GetProduct(int index)
    {
        if (index >= 0 && index < Products.Count)
            return Products[index];

        return null;
    }
}