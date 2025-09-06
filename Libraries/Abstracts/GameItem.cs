using GameApp.Libraries.Interface;

namespace GameApp.Libraries.Abstracts
{
    public abstract class Gameitem : IGameItem
    {
        public string name;
        

        protected Gameitem(string name)
        {
            this.name = name;
        }

        //buy
        public void ShowInfo()
        {
            Console.WriteLine("You have bought " + this.name);
        }


        public abstract void UseItem();
    }
}

