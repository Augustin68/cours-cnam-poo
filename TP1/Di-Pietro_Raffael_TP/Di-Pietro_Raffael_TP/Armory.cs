using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Pietro_Raffael_TP
{
    internal class Armory
    {
        List<Weapon> weapons = new List<Weapon>();

        public Armory()
        {
            this.Init();
        }

        private void Init()
        {
            this.AddWeapon(new Weapon("laser", 50, 100, EWeaponType.Direct));
            this.AddWeapon(new Weapon("tête chercheuse", 20, 50, EWeaponType.Guided));
            this.AddWeapon(new Weapon("grenade", 30, 40, EWeaponType.Explosive));
        }

        public void ViewArmory()
        {
            Console.WriteLine("== Armes de l'armurerie ==");
            this.weapons.ForEach(weapon =>
            {
                Console.WriteLine(weapon.ToString());
            });
            Console.WriteLine("====");
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
    }
}
