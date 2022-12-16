using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using warriorwars.Enum;

namespace warriorwars.Equipment
{
    internal class Armor
    {
        private const int GOODGUYARMOR = 5;
        private const int BADGUYARMOR = 5;

        private int armorPoints;

        public int ArmorPoints 
        { get
            {
                return armorPoints;
            }
            
        }

        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.Goodguy:
                    armorPoints = GOODGUYARMOR;
                    break;
                case Faction.Badguy:
                    armorPoints = BADGUYARMOR;
                    break;
                default:
                    break;
            }

        }
    }
}
