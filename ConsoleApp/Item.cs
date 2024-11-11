public class Item
{
    public string Name { get; set; }
    public int Quantity { get; set; }

    public Item(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public override string ToString()
    {
        return $"{Name} ({Quantity})";
    }
}
