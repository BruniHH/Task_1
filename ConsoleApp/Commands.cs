using System.Security.Cryptography.X509Certificates;
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
            this.CreatePlayer();
        }
        if (this.com == "/show"){
            Player p = new("",1);
            string mess = Console.ReadLine();
            p.DisplayPlayers(mess);
        }
    }

    public void CreatePlayer(){
        string UserName;
        int UserID;
        Console.WriteLine("Введите UserName");
        UserName = Console.ReadLine();
        UserID = 1111111;
        Player p = new(UserName, UserID);
        p.SavePlayers(p);
    }
}
