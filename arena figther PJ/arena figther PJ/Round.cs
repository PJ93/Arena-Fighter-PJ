using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_figther_PJ
{
    class Round
    {
        Character enemy;
        Character player;

        public Round(Character player, Character enemy)
        {
            this.enemy = enemy;
            this.player = player;
        }

        public int status = 0; //idea to use this as the value to help battle judge what happens

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }



        public void Results(Character player, Character enemy)
        {
            bool fighting = true;
            while (fighting)
            {
                Console.ReadKey();
                //Round – one round of dice rolling; should correspond to a post in the battle log
                //d1-6
                Random rnd = new Random();

                int Playerroll = rnd.Next(1, 6);
                int Enemyroll = rnd.Next(1, 6);


                Console.WriteLine(player.Name + " roll a " + Playerroll);
                Console.WriteLine( enemy.Name + " rolls a " + Enemyroll);
                Console.WriteLine("========================================================");
                if (player.STR + Playerroll > enemy.STR + Enemyroll)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(player.Name + " lands a devastating blow on "+ enemy.Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("========================================================");
                    enemy.HP = (enemy.HP - player.ATK);
                }
                else if (enemy.STR + Enemyroll > player.STR + Playerroll)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(enemy.Name +" lands a powerful blow on "+player.Name);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("========================================================");
                    player.HP = player.HP - enemy.HP;
                }
                else if(player.STR+Playerroll == enemy.STR + Enemyroll)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Both combatans searches for an opening in the other but can't find one");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("========================================================");
                    status = 0;
                }
                
                //player.ATK = 10; //only use to test that the code worked
                Console.ReadKey(true);
                player.Showstats();
                enemy.Showstats();
                Console.WriteLine("========================================================");
                if (player.HP < 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(player.Name + " Is dead.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("========================================================");
                    player.alive = false;
                    fighting = false;
                }
                else if (enemy.HP < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(player.Name + " Is victorious");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("========================================================");
                    fighting = false;
                    Console.Clear();
                }

            }//fighting

        }//results

        public void Fight()
        {
            player.Showstats();
            enemy.Showstats();

            Round combat = new Round(player, enemy);
            combat.Results(player, enemy);

        }


    }//class
}//namespace
