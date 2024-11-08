namespace Players;


class Player{

    public string UserName{ get;set; }
    public Random rnd = new();
    public int UserID{ get;set; }
    public static List<Player> AllPlayers = new(){};

    public Player(string name){
        UserName = name;
        UserID = rnd.Next(10000000,100000000);
    }

    public void SavePlayers(Player p){
        AllPlayers.Add(p);
    }

    public void DisplayPlayers(string mess){

        foreach(var p in AllPlayers){
            if (mess.Contains(p.UserID.ToString())){
                Console.WriteLine(p.UserName);
            }
        }
    }
}