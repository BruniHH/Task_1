namespace Players;

class Player{

    public string UserName{get;set;}
    public int UserID{get;set;}

    public Player(string name, int ID){
        this.UserName = name;
        this.UserID = ID;
    }

    public void CPlayer(){
        Console.WriteLine("Введите UserName");
        this.UserName = Console.ReadLine();
        this.UserID = 1111111;
        Console.WriteLine($"Ваш ник:{this.UserName}, ваш ID:{this.UserID}");
    }
}