using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarofArmies.Classes
{
    class BlueArmy : Army
    {
        private BlueArmy()
        {
            armyPanelName = "panel1";
            armyPicture = global::WarofArmies.Properties.Resources.blue;
        }

        private static BlueArmy instance;

        public static BlueArmy giveInstance()
        {
            if (instance == null)
            {
                instance = new BlueArmy();
            }
            return instance;
        }
    }
}
