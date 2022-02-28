using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarofArmies.Classes
{
    public abstract class Weapon
    {
        public int cooldownTime { get; set; }
        public int attackPoint { get; set; }
        public enum attackTypes
        {
            normalAttack,
            criticAttack,
            missAttack,
            instantKillAttack           
        }

        public attackTypes attackType;
                
        

        public Soldier attack(Soldier enemy)
        {
            double finalAttackPoint = attackPointCalculate();
            
            if (finalAttackPoint == 0)
            {
            }
            else if (enemy.armor.health > 0)
            {
                enemy.armor.health = enemy.armor.health - enemy.armor.defencePoint;
                enemy.health -= finalAttackPoint - enemy.armor.defencePoint;
            }
            else if (enemy.armor.health <= 0)
            {
                enemy.health -= finalAttackPoint;
            }
            return enemy;
        }

        public double attackPointCalculate()
        {
            double lastAttackPoint;
            int hitRate = randomHitRate();
            int rate = attackTypeMultiply();
            lastAttackPoint = (double)attackPoint * ((double)hitRate / 100) * rate * Soldier.power;
           return lastAttackPoint;
        }

        public int randomHitRate()
        {
            int hitRate = Army.randomGive().Next(70, 120);

            return hitRate;
        }

        public int randomAttackType()
        {
            int AttackTypeNumber = Army.randomGive().Next(0, 100);

            return AttackTypeNumber;

        }

        

        public int attackTypeMultiply()
        {
            attackTypes attackType = CalculateattackType();
            int rate = -1;

            switch (attackType)
            {
                case attackTypes.missAttack:
                    rate = 0;
                    break;
                case attackTypes.normalAttack:
                    rate = 1;
                    break;
                case attackTypes.criticAttack:
                    rate = 2;
                    break;
                case attackTypes.instantKillAttack:
                    rate = 100;
                    break;
            }
            return rate;
        }

        public attackTypes CalculateattackType()
        {
            int randomAttackTypeNumber = randomAttackType();
            if (randomAttackTypeNumber == 0)
            {
                attackType = attackTypes.instantKillAttack;
            }
            else if (randomAttackTypeNumber >= 1 && randomAttackTypeNumber <= 6)
            {
                attackType = attackTypes.criticAttack;
            }
            else if (randomAttackTypeNumber >= 7 && randomAttackTypeNumber <= 12)
            {
                attackType = attackTypes.missAttack;
            }
            else if (randomAttackTypeNumber >= 13 && randomAttackTypeNumber <= 100)
            {
                attackType = attackTypes.normalAttack;
            }
            return attackType;
        }



    }
}
