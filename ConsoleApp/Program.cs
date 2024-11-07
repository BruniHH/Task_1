using Command;
class Program
{
	private static void Main(string[] args)
	{
        string a;
		while(true){
            Console.WriteLine("Привет! Введи комманду -->");
            a = Console.ReadLine();

            Commands c = new(a);
            c.WhatCmd();

            if (a=="/exit"){
                Environment.Exit(0);
            }
        }
	}
}