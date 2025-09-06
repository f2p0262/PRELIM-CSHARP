using GameApp.Libraries.Abstracts;

namespace GameApp.Libraries.NewObjects
{
    public class Shield : Gameitem
    {
        public int Defense;
        public Shield(string name, int Defense) : base(name)
        {
            this.Defense = Defense;
        }
        public override void UseItem()
        {
            Console.WriteLine($"You equipped {this.name}. Defense increased by {this.Defense}%!");
        }
    }
}