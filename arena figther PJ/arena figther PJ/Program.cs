using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_figther_PJ
{
    class Program
    {
        static void Main(string[] args)
        {

            /*3 stats, hp, attack strength
             * rolling dice will add to these
             * name at star
             * 
             */

            //player related values

            Battle battle = new Battle();
            battle.Maingame();
            //battle.Fight();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("GAME OVER");
            Console.ReadKey();
        }
    }

        //private static void parse(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
