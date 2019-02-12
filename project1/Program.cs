using System;
using System.Collections.Generic;

namespace project1
{


    class Program
    {
        static void Main(string[] args)
        {
            int[,] idNumber = new int[8, 5]
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11, 12, 13, 14, 15},
                {16, 17, 18, 19, 20},
                {21, 22, 23, 24, 25},
                {26, 27, 28, 29, 30},
                {31, 32, 33, 34, 35},
                {36, 37, 38, 39, 40}
            };

            string[,] name = new string[8, 5]
            {
                {"Dwayne Haskins", "Kyler Murray", "Drew Lock", "Daniel Jones", "Will Grier"},
                {"Josh Jacobs", "Damien Harris", "David Montgomery", "Justice Hill", "Devin Singletary"},
                {"D.K. Metclaf", "A.J. Brown", "N'Keal Harry", "Marquise Brown", "Kelvin Harmon"},
                {"Nick Bosa", "Quinnen Williams", "Ed Oliver", "Jeffery Simmons", "Clelin Ferrell"},
                {"Greedy Williams", "Deandre Baker", "Byron Murphy", "Deionte Thompson", "Amani Oruwariye"},
                {"Noah Fant", "Irv Smith", "T.J. Hockenson", "Kaden Smith", "Josh Oliver"},
                { "Josh Allen", "Devin White", "Montez Sweat", "Mack Wilson", "Devin Bush" },
                {"Jonah Williams", "Greg Litte", "Cody Ford", "Jawaan Taylor", "Yodny Cajuste"}
            };

            string[,] position = new string[8, 5]
            {
                {"Quarterback", "Quarterback", "Quarterback", "Quarterback", "Quarterback"},
                {"Running Back", "Running Back", "Running Back", "Running Back", "Running Back"},
                {"Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver", "Wide-Receiver"},
                {"Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman", "Defensive Lineman"},
                {"Defensive Back", "Defensive Back", "Defensive Back", "Defensive Back", "Defensive Back"},
                {"Tight End", "Tight End", "Tight End", "Tight End", "Tight End"},
                {"Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer", "Line-Backer"},
                {"Offensive Tackle", "Offensive Tackle", "Offensive Tackle", "Offensive Tackle", "Offensive Tackle"}
            };

            string[,] ranking = new string[8, 5]
            {
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"},
                {"The Best", "2nd Best", "3rd Best", "4th Best", "5th Best"}
            };

            string[,] school = new string[8, 5]
            {
                {"Ohio St.", "Oklahoma", "Missouri", "Duke", "West Virginia"},
                {"Alabama", "Alabama", "Iowa St.", "Oklahoma St.", "FAU"},
                {"Ole Miss", "Ole Miss", "Arizona St.", "Oklahoma", "NC State"},
                {"Ohio St.", "Alabama", "Houston", "Miss. St.", "Clemson"},
                {"LSU", "Georgia", "Washingtion", "Alabama", "Penn State"},
                {"Iowa", "Alabama", "Iowa", "Stanford", "San Jose St."},
                {"Kentuky", "LSU", "Miss. State", "Alabama", "Michigan"},
                {"Alabama", "Ole Miss", "Oklahoma", "Florida", "West Virgina"}
            };

            int[,] salary = new int[8, 5]
            {
                {26400100, 20300100, 17420300, 13100145, 10300000},
                {24500100, 19890200, 18700800, 15000000, 11600400},
                {23400000, 21900300, 19300230, 13400230, 10000000},
                {26200300, 22000000, 16000000, 18000000, 13000000},
                {24000000, 22500249, 20000100, 16000200, 11899999},
                {27800900, 21000800, 17499233, 27900200, 14900333},
                {22900300, 19000590, 18000222, 12999999, 10000100},
                {23000000, 20000000, 19400000, 16200700, 15900000}
            };

            
            //List of Players
            List<Player> playerList = new List<Player>();
            List<Player> coachPicks = new List<Player>();

            //Variable for Salary
            int moneyLeft = 95000000;
            int moneySpent = 0;

            //For loop to create string of list
            for (var i = 0; i < 8; i++)
            {
                for (var x = 0; x < 5; x++)
                {
                    Player aPlayer = new Player(name[i, x], position[i, x], school[i, x], salary[i, x], ranking[i, x], idNumber[i, x]);
                    playerList.Add(aPlayer);
                }
            }

            // Greet to user
            Greeting();


            string start = Console.ReadLine();
            string EXIT = "x"; //sentinel value

            while (start != EXIT)
            {
                Console.Clear();

                //Write list to console
                playerList.ForEach(x => Console.WriteLine(x.ToString()));

                Console.WriteLine("\nEnter the number associated with the player you wish to draft:");

                //Convert user input to INT
                int pick = Convert.ToInt32(Console.ReadLine());


                for (int i = playerList.Count - 1; i >= 0; i--)
                {
                    if (playerList[i].idNumber == pick)
                    {
                        coachPicks.Add(playerList[i]);
                        moneyLeft = moneyLeft - playerList[i].salary;
                        moneySpent = moneySpent + playerList[i].salary;
                        playerList.RemoveAt(i);
                    }

                }
                if (moneyLeft <= 0)
                {
                    Console.Clear();

                    Console.WriteLine("You've exceeded the maximum budget alloted for the drafting. The program will now close.");
                    Console.WriteLine("Please restart the program if you wish to try again.");
                    start = "x";
                    Console.ReadLine();
                }
                else
                {
                    if (coachPicks.Count >= 5)
                    {
                        start = "x";
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine("\n--------------------------------------------------------------------------\nYou've drafted:");
                        foreach (Player i in coachPicks)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        Console.WriteLine("\nCurrent cost of drafted players: $" + moneySpent);
                        Console.WriteLine("Current budget $" + moneyLeft);
                        Console.WriteLine("\n--------------------------------------------------------------------------");
                        Console.WriteLine("To continue drafting players, Press 'Enter'");
                        Console.WriteLine("To exit the program, Press 'x'");
                        start = Console.ReadLine();
                    }
                }

            } //end WHILE

            Console.Clear();
            Console.WriteLine("\n--------------------------------------------------------------------------\nYou've drafted:");
            foreach (Player i in coachPicks)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine("\nTotal cost: $" + moneySpent);
            Console.WriteLine("\nAmount of budget leftover: $" + moneyLeft);
            Closing();
            Console.ReadLine();


        }// end of MAIN

        static void Greeting()
        {
            Console.WriteLine("Welcome to the NFL Drafting Program!");
            Console.WriteLine("This program will assit you in a simulated environment for drafting potential players.");
            Console.WriteLine("To begin the program, please press 'Enter'");
        }

        static void Closing()
        {
            Console.WriteLine("--------------------------------------------------------------------------\n");
            Console.WriteLine("This concludes the NFL Drafting Program.");
        }
    }

    public class Player
    {
        public int idNumber { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string school { get; set; }
        public int salary { get; set; }
        public string ranking { get; set; }

        public Player(string name, string position, string school, int salary, string ranking, int idNumber)
        {
            this.idNumber = idNumber;
            this.name = name;
            this.position = position;
            this.school = school;
            this.salary = salary;
            this.ranking = ranking;
        }

        public override string ToString()
        {
            return String.Format("{0,-5} | {1,-16} | {2,-8} | {3,-17} | {4,-13} | {5:N0} |", idNumber + ". ", name, ranking, position, school, "$" + salary);
        }
    }//end of class Player
}