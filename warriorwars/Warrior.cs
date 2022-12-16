using System;
using warriorwars.Enum;
using warriorwars.Equipment;

namespace warriorwars
{
    internal class Warrior
    {
        private const int GOODGUYSTARTINGHEALTH = 20;
        private const int BADGUYSTARTINGHEALTH = 20;

        private readonly Faction FACTION;
        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive 
        { 
            get
            {
                return isAlive;
            }
            
        }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            FACTION = faction;
            isAlive = true;

            switch (faction)
            {
                case Faction.Goodguy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOODGUYSTARTINGHEALTH;
                    break;
                case Faction.Badguy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BADGUYSTARTINGHEALTH;
                    break;
                default:
                    break;
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;

            AttackResult(enemy, damage);
        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                tools.ColorfulWriteLine($"{enemy.name} is dead!", ConsoleColor.Red);
                tools.ColorfulWriteLine($"{name} is victorious!", ConsoleColor.Green);
            }
            else
            {
                Console.WriteLine($"{name} attacked the {enemy.name}. {damage} damage was inflicted to {enemy.name}, remaining health of {enemy.name} is {enemy.health}");
            }
        }
    }
}
