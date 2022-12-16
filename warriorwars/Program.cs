using System;
using System.Threading;
using warriorwars.Enum;

namespace warriorwars
{
    class Program
    {
        static Random rng = new Random();
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("ADI", Faction.Goodguy);
            Warrior badGuy = new Warrior("AARON", Faction.Badguy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                if (rng.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);

                }
                else
                {
                    badGuy.Attack(goodGuy);
                }

                Thread.Sleep(500);
            }
        }
    }
}
