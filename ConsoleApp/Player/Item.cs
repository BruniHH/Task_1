namespace It;
public class Item
{
    public string Name { get;set; }
    public int Id { get;set; }
    public static List<string> Rarities = new List<string>{
        "common",
        "rare",
        "unique",
        "mythic",
        "legendary"
    };
    public string Rarity { get;set; }

    public Item(string name, int id)
    {
        Name = name;
        Random rnd = new();
        Id = id;
        Rarity = Rarities[rnd.Next(0,(Rarities.Count-1))];
    }

    public override string ToString()
    {
        return $"{Name} {Id} {Rarity}";
    }
}
