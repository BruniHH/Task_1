//Класс объекта игрок
using Program;
using Inv;
using ClassIItem;

namespace Players;
public class Player{

    public string UserName{ get;set; }
    public int UserID{ get;set; }
    public int PosX{ get;set; }
    public int PosY{ get;set; }
    Inventory PlayerInv = new();

    public Player(string name){
        UserName = name;
        Random rnd = new();
        UserID = (rnd.Next( 10000000,100000000 ));
        PosX = rnd.Next( 0,101 );
        PosY = rnd.Next( 0,101 );
        PlayerInv.AddRandomItem();
    }
    public override string ToString()
    {
        return $"Имя пользователя:{UserName}\nID:{UserID}\nКоординаты:({PosX};{PosY})\n{PlayerInv.PlayerItems[0]}";
    }
}
