using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Di_Pietro_Raffael_TP
{
    internal class Spaceship
    {
        private int maxShield;
        private int maxStructure;

        private int currentShield { get; set; }
        private int currentStructure { get; set; }

        private bool isDestroyed { get; set; }

        public Spaceship(int maxShield, int maxStructure)
        {
            this.maxShield = maxShield;
            this.maxStructure = maxStructure;

            this.currentShield = maxShield;
            this.currentStructure = maxStructure;

            this.isDestroyed = maxShield <= 0 && maxStructure <= 0;
        }
    }
}
