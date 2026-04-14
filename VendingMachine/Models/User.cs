namespace VendingMachine.Models;

public class User
{
    public string Name { get; set; }
    public int Money { get; private set; }
    public List<Product> BoughtItems { get; set; } = new List<Product>();

    public User(string name, int money)
    {
        Name = name;
        Money = money;
    }

    public bool SpendMoney(int amount)
    {
        if (Money >= amount)
        {
            Money -= amount;
            return true;
        }
        return false;
    }

    public void AddItem(Product product)
    {
        BoughtItems.Add(product);
    }
}