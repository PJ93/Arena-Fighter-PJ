using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_figther_PJ
{
    class Battle
    {

        //Battle – for the battle itself; should contain the log of the battle, as well as references to both the player and the opponent
        public Character player = new Character();
        //public int status = 0;
        //int awnser = 0;
        public int score = 0;

        List<string> kills = new List<string>();


        public void Maingame()
        {
            Console.WriteLine("ENTER YOUR NAME");
            player.Name = Console.ReadLine();
            player.Showstats();
            Console.WriteLine("Well then " + player.Name + " get ready for battle!");

            //Console.WriteLine(player.ATK);
            

            bool keepalive = true;
            while (keepalive)
            {

                Character enemy = new Character();
                Round round = new Round(player, enemy);
                //player.Showstats();
                Console.WriteLine("What do you wanna do?");
                Console.WriteLine("F. Find an opponent");
                Console.WriteLine("R. Retire from the fighting");


                //string a = Console.ReadLine();
                //char b = Console.ReadKey();
                //awnser = int.Parse(a);

                var input = Console.ReadKey(true);

                switch (input.Key)
                {
                    case ConsoleKey.F:
                        Console.Clear();
                        Console.WriteLine("Your opponent is:");
                        enemy.Showstats();
                        Console.WriteLine("========================================================");
                        Console.ReadKey(false);
                        round.Fight();
                        if (player.alive == false)
                        {
                            keepalive = false;
                            Console.Clear();
                            Console.WriteLine("Score: " + score);
                            Console.WriteLine();
                            player.Showstats();
                            foreach(string Ename in kills)
                            {
                                Console.WriteLine(player.Name + " killed " + Ename);
                            }
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(player.Name + " got killed by " + enemy.Name);
                        }
                        else
                        {
                            score = score++;
                            kills.Add(enemy.Name); 
                        }
                        break;
                    case ConsoleKey.R:
                        Console.Clear();
                        Console.WriteLine("You abandon the fighting circle.");
                        foreach (string Ename in kills)
                        {
                            Console.WriteLine(player.Name + " killed " + Ename);
                        }
                        keepalive = false;
                        break;

                    default:
                        Console.WriteLine("Only use 1 or 2");
                        break;
                }//switch

            }//keepalive

        }//maingame

        public Battle()
        {

        }



    }//class

}//namespace
