public class Inventory
{
    private List<Item> items;

    public Inventory()
    {
        items = new List<Item>();
    }

    public void AddItem(string name, int quantity)
    {
        var existingItem = items.Find(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            items.Add(new Item(name, quantity));
        }
    }

    public void RemoveItem(string name, int quantity)
    {
        var existingItem = items.Find(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (existingItem != null)
        {
            if (existingItem.Quantity >= quantity)
            {
                existingItem.Quantity -= quantity;
                if (existingItem.Quantity == 0)
                {
                    items.Remove(existingItem);
                }
            }
            else
            {
                Console.WriteLine($"Not enough {name} in inventory.");
            }
        }
        else
        {
            Console.WriteLine($"{name} not found in inventory.");
        }
    }

    public void DisplayInventory()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Inventory is empty.");
        }
        else
        {
            Console.WriteLine("Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
