using System.Security.Cryptography.X509Certificates;
using Players;

namespace Command;

class Commands{


    public void WhatCmd(string Com){
        if (Com == "/help")Console.WriteLine("/help - выводит все комманды\n/stop - останавливает программу");
        if (Com == "/create"){
            CreatePlayer();
            return;
        }
        if (Com.Contains("/show")){
            Player p = new("");
            p.DisplayPlayers(Com);
        }
    }

    public void CreatePlayer(){

        Console.WriteLine("Введите UserName");
        string UserName = Console.ReadLine();
        Random rnd = new(); //player
        Player p = new(UserName);
        Console.WriteLine($"Ваш ник: {UserName}\nВаш id: {p.UserID}");
        p.SavePlayers(p);
    }
}
