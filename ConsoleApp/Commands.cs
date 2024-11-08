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
            Player p = new("",1);
            p.DisplayPlayers(Com);
        }
    }

    public void CreatePlayer(){

        Console.WriteLine("Введите UserName");
        string UserName = Console.ReadLine();
        Random rnd = new();
        int UserID = rnd.Next(10000000,99999999+1); //player
        Player p = new(UserName, UserID);
        Console.WriteLine($"Ваш ник: {UserName}\nВаш id: {UserID}");
        p.SavePlayers(p);
    }
}
