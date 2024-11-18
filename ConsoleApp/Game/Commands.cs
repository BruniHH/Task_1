using Players;
using Program;
using OriginGame;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Command;

public class Commands{



    public void WhatCmd(string com){
        if ( com.Contains("/help") )Console.WriteLine("/help - выводит все комманды\n/stop - останавливает программу");
        if ( com.Contains("/create") ){
            CreatePlayer( com.Substring(8) );
            return;
        }
        if ( com.Contains("/show") ){
            foreach( var p in Game.AllPlayers ){
                Console.WriteLine(p);
            }
        }
        if ( com.StartsWith("/search") ){
            foreach( var p in Game.AllPlayers ){
                Console.WriteLine($"{p.UserName} { p.UserID }");
            }
            Console.WriteLine("Выберите игрока --> ");
            string choose = Console.ReadLine();
            foreach( var p in Game.AllPlayers ){
                if (choose == p.UserName || choose == p.UserID.ToString()) Console.WriteLine(p);
            }
        }
    }

    public void CreatePlayer(string name){
        Player p = new( name );
        Game.AllPlayers.Add( p );
        Console.WriteLine( $"Ваш ник: {p.UserName}\nВаш id: {p.UserID}" );
    }
}
//newww
