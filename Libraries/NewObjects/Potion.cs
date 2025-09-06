using GameApp.Libraries.Abstracts;

namespace GameApp.Libraries.NewObjects
{
    public class Potion : Gameitem
    {
        public int HealAmount;
        public Potion(string name, int HealAmount) : base(name)
        {
            this.HealAmount = HealAmount;
        }
        public override void UseItem()
        {
            Console.WriteLine($"You drank {this.name}. Restored {this.HealAmount}% HP!");
        }
    }
}