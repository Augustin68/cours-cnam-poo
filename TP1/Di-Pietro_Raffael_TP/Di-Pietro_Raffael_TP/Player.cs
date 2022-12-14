using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Pietro_Raffael_TP
{
    internal class Player
    {
        private String firstName;
        private String lastName;
        private String alias;
        public String name;

        private Spaceship defaultSpaceShip;
        

        public Player(String firstName, String lastName, String alias)
        {
            this.firstName = FormatName(firstName);
            this.lastName = FormatName(lastName);
            this.alias = FormatName(alias);

            this.name = this.firstName + " " + this.lastName;

            this.defaultSpaceShip = new Spaceship("Vaisseau de " + this.alias, 100, 100);
        }

        private static String FormatName(String name)
        {
            return char.ToUpper(name[0]) + name.Substring(1).ToLower();
        }

        public override string ToString()
        {
            return this.alias + " (" + this.firstName + " " + this.lastName + ")";
        }

        public override bool Equals(object? obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(obj.GetType() != typeof(Player))
            {
                return false;
            }

            return this.alias == ((Player)obj).alias;
        }
    }
}
