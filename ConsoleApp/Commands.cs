using Players;

namespace Command;

class Commands{
    public string com{get;set;}

    public Commands(string c){
        this.com = c;
    }

    public void WhatCmd(){
        if (this.com == "/help"){
            Console.WriteLine("/help - выводит все комманды\n/stop - останавливает программу");
        }
        if (this.com == "/create"){
            Player p = new("", 1);
            this.CreatePlayer(p);
        }
    }

    public void CreatePlayer(Player p){
        p.CPlayer();
        
    }
}
