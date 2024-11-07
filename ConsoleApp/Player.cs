namespace Players;

class Player{

    public string UserName{get;set;}
    public int UserID{get;set;}
    static List<Player> all_players = new List<Player>(){};

    public Player(string name, int ID){
        this.UserName = name;
        this.UserID = ID;
    }

    public void SavePlayers(Player p){
        all_players.Add(p);
    }

    public void DisplayPlayers(string mess){

        foreach(var p in all_players){
            if (mess.Contains(p.UserID.ToString())){
                Console.WriteLine(p.UserName);
            }
        }
    }
}