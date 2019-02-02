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

            Player aPlayer = new Player
            {
                Name = "Dwayne Haskins",
                College = "Ohio St.",
                Cost = string.Format("${0:C}", 26400100)
            };

            Console.WriteLine(aPlayer.ToString());
            

        }

        public override string ToString()
        {
            return String.Format("{0} \n, {1} \n, {2} \n, {3} \n", );
        }

        class Position
        {
            public string playerPosition { get; set; }

        }

        class Player
        {
            public string Name { get; set; }
            public string College { get; set; }
            public string Cost { get; set; }
            public Player()
            {

            }
        }
    }
}
