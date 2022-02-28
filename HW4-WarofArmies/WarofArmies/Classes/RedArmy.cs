using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarofArmies.Classes
{
    class RedArmy : Army
    {        

        private RedArmy()
        {
            armyPanelName = "panel2";
            armyPicture = global::WarofArmies.Properties.Resources.red;
        }

        private static RedArmy instance;

        public static RedArmy giveInstance()
        {
            if (instance == null)
            {
                instance = new RedArmy();                
            }
            return instance;
        }

    }
    }
