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

        public void Main()
        {
            SpaceInvaders spaceInvaders = new SpaceInvaders();

            Console.WriteLine("Voici nos 3 joueurs :");
            Console.WriteLine(this.p1.ToString());
            Console.WriteLine(this.p2.ToString());
            Console.WriteLine(this.p3.ToString());
        }

        private void Init()
        {
            this.p1 = new Player("Jean", "Marc", "El boss");
            this.p2 = new Player("Hector", "Salamanca", "Muchacho");
            this.p3 = new Player("Filipe", "Rodriguez", "Roi de la merguez");
        }
    }
}
