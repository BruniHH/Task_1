
using Command;
using Players;
namespace Game;
public class Program{
    public static List<Player> AllPlayers{ get;set; } = new();

    private static void Main(string[] args){
        Console.Clear();
        Commands c = new();
		while(true){
            Console.WriteLine("Привет! Введи комманду -->");
            string a = Console.ReadLine();
            c.WhatCmd(a);
            if (a.StartsWith("/exit")) Environment.Exit(0);
        }

    }

}
