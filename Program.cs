using GameApp.Libraries.NewObjects;
using GameApp.Libraries.Interface;

namespace GameApp
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Shield Shield = new Shield("Shield", 20);
            Shield.UseItem();
            Shield.ShowInfo();

            Potion Potion = new Potion("Potion", 50);
            Potion.UseItem();
            Potion.ShowInfo();

           
        }

    }
}

