using Players;
using Game;

namespace Command;

class Commands{


    public void WhatCmd(string com){
        if ( com.Contains("/help") )Console.WriteLine("/help - выводит все комманды\n/stop - останавливает программу");
        if ( com.Contains("/create") ){
            string[] parts = com.Split(" ");
            CreatePlayer( parts[1] );
            return;
        }
        if ( com.Contains("/show") ){
            foreach( var p in Program.AllPlayers ){
                Console.WriteLine(p.ToString());
            }
        }
    }

    public void CreatePlayer(string name){
        string UserName = name;
        Player p = new(UserName);
        Program.AllPlayers.Add(p);
        Console.WriteLine($"Ваш ник: {UserName}\nВаш id: {p.UserID}");
    }
}
