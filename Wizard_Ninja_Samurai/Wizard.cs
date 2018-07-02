
namespace Wizard_Ninja_Samurai
{
    public class Wizard : Human
    {
        public Wizard(string name, Weapon weapon) :base(name, weapon)
        {
            Health = 50;
            Intelligence = 25;
        }
    }
}