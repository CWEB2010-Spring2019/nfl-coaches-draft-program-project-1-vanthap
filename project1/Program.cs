using System;
using System.Collections.Generic;
using static System.Console;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the NLF Drafting Program.");
            Console.WriteLine("This program will assist you in drafting potential players in a simulated environment.");
            Console.WriteLine("Please press any key to continue");
            Console.ReadLine();

            Player aPlayer = new Player();
            aPlayer.Name = "Dwayne Haskins";
            aPlayer.College = "Ohio St.";
            aPlayer.College = "$26,400,100";



            





        }

        class Position
        {
            public string playerPosition { get; set; }

        }

        class Player
        {
            public string Name { get; set; }
            public string College { get; set; }
            public int Cost { get; set; }
        }
    }
}
