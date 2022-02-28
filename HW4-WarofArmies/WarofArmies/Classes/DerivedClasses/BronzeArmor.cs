using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarofArmies.Classes.DerivedClasses
{
    public class BronzeArmor : Armor
    {
        private BronzeArmor()
        {
            defencePoint = 2;
            health = 15;
        }
        private static BronzeArmor instance;

        public static BronzeArmor giveInstance()
        {
            if (instance == null)
            {
                instance = new BronzeArmor();
            }
            return instance;
        }

    }
}
