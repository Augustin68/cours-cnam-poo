using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Pietro_Raffael_TP
{
    internal class Weapon
    {
        public readonly String name;
        public readonly int minDamage;
        public readonly int maxDamage;
        EWeaponType type;

        public Weapon(String name, int minDamage, int maxDamage, EWeaponType type)
        {
            this.name = name;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.type = type;
        }

        public override String ToString()
        {
            return this.name + " (max-dégats: " + this.maxDamage + " min-dégats: " + this.minDamage + ")";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != typeof(Weapon))
            {
                return false;
            }
            return this.name == ((Weapon)obj).name;
        }
    }
}
