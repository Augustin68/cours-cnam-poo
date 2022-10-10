using System;
using System.Collections.Generic;
namespace Di_Pietro_Raffael_TP
{
    internal class SpaceInvaders
    {
        private Player p1;
        private Player p2;
        private Player p3;

        public SpaceInvaders()
        {
            this.Init();
        }

        static void Main()
        {
            SpaceInvaders spaceInvaders = new SpaceInvaders();

            Console.WriteLine("Voici nos 3 joueurs :");
            Console.WriteLine(spaceInvaders.p1.ToString());
            Console.WriteLine(spaceInvaders.p2.ToString());
            Console.WriteLine(spaceInvaders.p3.ToString());
        }

        private void Init()
        {
            this.p1 = new Player("Jean", "MARC", "El boss");
            this.p2 = new Player("Hector", "salamanca", "Muchacho");
            this.p3 = new Player("Filipe", "Rodriguez", "Roi de la merguez");
        }
    }
}
