using Lexicon.CSharp.InfoGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arena_figther_PJ
{
    class Character
    {
        //Character – for both the Character and the opponents
        
        static Random rng = new Random();
        static InfoGenerator infoGen = new InfoGenerator(rng.Next());

        string name;
        int hp = rng.Next(1,6);
        int atk = rng.Next(1,6);
        int str = rng.Next(1, 6);
        public bool alive = true;


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Length > 1)//> 1 = 2 and above
                {
                    name = value;
                }
            }
        }

        public int HP
        {
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                if (value < 0)
                {
                    hp = 0;
                    //string dead = hp.ToString("Dead");
                }
                
            }
        }

        public int ATK
        {
            get
            {
                return atk;
            }
            set
            {
                if (value > 0)
                {
                    atk = value;
                }
            }
        }

        public int STR
        {
            get
            {
                return str;
            }
            set
            {
                if (value > 0)
                {
                    str = value;
                }
            }
        }

        public Character()
        {
            this.name = infoGen.NextFirstName();
        }

        public Character(string name)
        {
            this.name = name;
        }

        public void Showstats()
        {
            Console.WriteLine("NAME: " + name);
            Console.WriteLine("HP: {0}, Atk: {1}, Str: {2}", hp, atk, str); //{0} index num wil go for the first value
        }

    }
}
