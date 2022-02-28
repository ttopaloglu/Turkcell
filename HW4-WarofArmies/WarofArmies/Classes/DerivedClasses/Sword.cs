using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WarofArmies.Classes.DerivedClasses
{
    public class Sword : Weapon
    {
        private Sword()
        {
            attackPoint = 10;
            cooldownTime = 1;
        }
        private static Sword instance;

        public static Sword giveInstance()
        {
            if (instance == null)
            {
                instance = new Sword();
            }
            return instance;
        }






    }
}
