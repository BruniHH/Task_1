using Game;

namespace Players;


public class Player{

    public string UserName{ get;set; }
    public int UserID{ get;set; }

    public Player(string name){
        UserName = name;
        Random rnd = new();
        UserID = rnd.Next(10000000,100000000);
    }

    public void DisplayPlayers(string mess){

        foreach(var p in Program.AllPlayers){
            Console.WriteLine($"{p}");
        }
    }
}
