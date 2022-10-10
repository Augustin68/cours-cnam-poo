using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Pietro_Raffael_TP
{
    internal class Weapon
    {
        private String name;
        private int minDamage;
        private int maxDamage;
        EWeaponType type;

        public Weapon(String name, int minDamage, int maxDamage, EWeaponType type)
        {
            this.name = name;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            this.type = type;
        }
    }
}
