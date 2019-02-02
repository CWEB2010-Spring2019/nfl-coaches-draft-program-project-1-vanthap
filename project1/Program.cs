using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            aPlayer.Cost = string.Format("${0:C}", 26400100);
            

            Console.WriteLine(aPlayer.ToString());
            

        }

        public override string ToString()
        {
            
            return string.Format("{0} \n, {1} \n, {2} \n, {3} \n", name, );
        }

        class Position
        {
            public string playerPosition { get; set; }

        }

        class Player
        {
            private string _name;
            private string _college;
            private string _cost;

            public string Name { get; set; }
            public string College { get; set; }
            public string Cost { get; set; }
            public Player()
            {

            }
        }
    }
}
