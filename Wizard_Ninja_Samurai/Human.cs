using System;
using System.Security.Cryptography;

namespace Wizard_Ninja_Samurai
{
    public class Human
    {
        public string Name;
        public int Health { get; set; } = 100;
        public int Strength { get; set; } = 3;
        public int Intelligence { get; set; } = 3;
        public int Dexterity { get; set; } = 3;
        private readonly Weapon _weapon;

        public Human(string name, Weapon weapon)
        {
            Name = name;
            _weapon = weapon;

        }

        public Human(string name, Weapon weapon, int str, int intel, int dex, int hp) :this(name, weapon)
        {
           Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Health = hp;
        }

        public override string ToString()
        {
            return
                $"Name: {Name}, Health: {Health}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}";
        }

        public void UseWeapon(Human victim)
        {
            _weapon.Attack(victim);
        }
  
    }
}