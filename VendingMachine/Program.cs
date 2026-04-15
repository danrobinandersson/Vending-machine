using VendingMachine.Data;
using VendingMachine.Models;
using VendingMachine.Services;

var user = new User("Player", 100);
var machine = new VendingMachine.Services.VendingMachine();

machine.Products = SeedData.GetProducts();

while (true)
{
    Console.WriteLine("\n--- VENDING MACHINE ---");
    Console.WriteLine("1. Show products");
    Console.WriteLine("2. Buy product");
    Console.WriteLine("3. Show my items");
    Console.WriteLine("4. Show money");
    Console.WriteLine("0. Exit");

    Console.Write("Choose: ");
    string input = Console.ReadLine();

    if (input == "1")
    {
        machine.ShowProducts();

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    else if (input == "2")
    {
        machine.ShowProducts();

        Console.Write("Choose item number: ");
        int choice = int.Parse(Console.ReadLine()!) - 1;

        var product = machine.GetProduct(choice);

        if (product == null)
        {
            Console.WriteLine("Invalid choice!");
        }
        else if (user.SpendMoney(product.Price))
        {
            user.AddItem(product);
            Console.WriteLine("Purchase successful!");
        }
        else
        {
            Console.WriteLine("Not enough money!");
        }

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    else if (input == "3")
    {
        Console.WriteLine("\n--- Your Items ---");

        foreach (var item in user.BoughtItems)
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    else if (input == "4")
    {
        Console.WriteLine($"You have: {user.Money} kr");

        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }

    else if (input == "0")
    {
        break;
    }
}