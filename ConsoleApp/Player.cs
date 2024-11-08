namespace Players;

class Player{

    public string UserName{get;set;}
    public int UserID{get;set;}
    public static List<Player> AllPlayers = new(){};

    public Player(string name, int ID){
        this.UserName = name;
        this.UserID = ID;
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