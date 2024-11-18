//Инвентарь игрока
using ClassIItem;
using ExistingObjects;
using Players;
namespace Inv;
public class Inventory
{
    public List<Item> PlayerItems { get; } = new List<Item>();

    public void AddRandomItem()
    {
        Random random = new Random();
        int randomIndex = random.Next(ExistingItems.AllItems.Count);
        Item randomItem = ExistingItems.AllItems[randomIndex];
        PlayerItems.Add(randomItem);
    }
}