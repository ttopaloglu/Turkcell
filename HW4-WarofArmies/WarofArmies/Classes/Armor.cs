using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarofArmies.Classes
{
    public abstract class Armor
    {
        public virtual double health { get; set; } 
        public virtual int defencePoint { get; set; }
    }
}
