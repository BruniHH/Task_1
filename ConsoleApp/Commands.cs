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
        if (this.com.Contains("/show")){
            Player p = new("",1);
            p.DisplayPlayers(this.com);
        }
    }

    public void CreatePlayer(){
        string UserName;
        int UserID;
        Console.WriteLine("Введите UserName");
        UserName = Console.ReadLine();
        Random id = new();
        UserID = id.Next(10000000,99999999);
        Player p = new(UserName, UserID);
        Console.WriteLine($"Ваш ник: {UserName}\nВаш id: {UserID}");
        p.SavePlayers(p);
    }
}
