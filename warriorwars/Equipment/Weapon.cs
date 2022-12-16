
using warriorwars.Enum;

namespace warriorwars.Equipment
{
    internal class Weapon
    {
        private const int GOODGUYARMOR = 5;
        private const int BADGUYDAMAGE = 5;

        private int damage;

        public int Damage 
            { 
                get
                {
                    return damage;
                } 
            }

        public Weapon(Faction faction) 
        {
            switch (faction)
            {
                case Faction.Goodguy:
                    damage = GOODGUYARMOR;
                    break;
                case Faction.Badguy:
                    damage = BADGUYDAMAGE;
                    break;
                default:
                    break;
            }
        }
    }
}
