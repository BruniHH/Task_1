using Command;
class Program
{
	private static void Main(string[] args)
	{
        Commands c = new();
		while(true){
            Console.WriteLine("Привет! Введи комманду -->");
            string a = Console.ReadLine();

            c.WhatCmd(a);

            if (a=="/exit"){
                Environment.Exit(0);
            }
        }
	}
}