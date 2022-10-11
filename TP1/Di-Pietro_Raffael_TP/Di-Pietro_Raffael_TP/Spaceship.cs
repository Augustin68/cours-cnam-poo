using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Pietro_Raffael_TP
{
    internal class Spaceship
    {
        private string name;
        private int maxShield;
        private int maxStructure;

        private int currentShield { get; set; }
        private int currentStructure { get; set; }

        private bool isDestroyed { get; set; }

        private List<Weapon> weapons = new List<Weapon>();

        public Spaceship(string name, int maxShield, int maxStructure)
        {
            this.maxShield = maxShield;
            this.maxStructure = maxStructure;

            this.currentShield = maxShield;
            this.currentStructure = maxStructure;

            this.isDestroyed = maxShield <= 0 && maxStructure <= 0;
        }

        public void AddWeapon(Weapon weapon)
        {
            this.weapons.Add(weapon);
        }

        public void RemoveWeapon(Weapon oWeapon)
        {
            this.weapons.Remove(oWeapon);
        }

        public void ClearWeapons()
        {
            this.weapons.Clear();
        }

        public void ViewWeapons()
        {
            Console.WriteLine("== Armes du vaisseau "+ this.name +"==");
            this.weapons.ForEach(weapon =>
            {
                Console.WriteLine(weapon.ToString());
            });
            Console.WriteLine("====");
        }

        public double AverageDamages()
        {
            double sum = 0;
            this.weapons.ForEach((weapon) =>
            {
                sum += (weapon.minDamage + weapon.maxDamage) / 2;
            });

            return sum;
        }
    }
}
