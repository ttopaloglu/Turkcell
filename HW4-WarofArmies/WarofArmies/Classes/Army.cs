using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarofArmies.Classes
{
    public class Army
    {
        System.Windows.Forms.Form.ControlCollection formControls = (System.Windows.Forms.Form.ControlCollection)Application.OpenForms["Form1"].Controls;
        public List<Soldier> soldiers = new List<Soldier>();
        public double totalHealth = 0;
        public Army enemy;
        private static Random rand = null;
        public string armyPanelName;
        public System.Drawing.Bitmap armyPicture;
        public int soldierId = 1;




        public static Random randomGive()
        {
            if (rand == null)
            {
                rand = new Random();
            }
            return rand;
        }

        public Army()
        {
            soldierId = 1;
        }

        public void AttackAll()
        {
            foreach (var soldier in soldiers)
            {
                soldier.attackToEnemy();
            }
        }

        public void calculateTotalHealth()
        {
            totalHealth = 0;
            foreach (var soldier in soldiers)
            {
                totalHealth += soldier.health;
            }
        }

        public void createSwordSoldiers(int numberOfSwordSoldier,Weapon weapon, Armor armor)
        {
            for (int i = 0; i < numberOfSwordSoldier; i++)
            {                
                Soldier newSoldier = new Soldier(this,weapon,armor);
                soldiers.Add(newSoldier);
            }            
        }

        

        

        public void deleteEnemy(Soldier deleteEnemy)
        {

            enemy.soldiers.Remove(deleteEnemy);
        }

        public  Soldier findEnemy(Soldier me)
        {
            bool tempEnemyBool = false;
            Soldier tempEnemy = null;
            foreach (var enemyItem in enemy.soldiers)
            {                
                if (enemyItem.enemy == me)
                {
                    return enemyItem;
                }
                if (!tempEnemyBool && enemyItem.isHaveEnemy == false)
                {                    
                    tempEnemy = enemyItem;
                    tempEnemyBool = true;
                }
            }
            if (tempEnemyBool)
            {
                tempEnemy.isHaveEnemy = true;
                return tempEnemy;
            }
            else
            {
                if (enemy.soldiers.Count != 0)
                {
                    Random randTaken = Army.randomGive();
                    int index = randTaken.Next(enemy.soldiers.Count);
                    return enemy.soldiers[index];
                }
                else
                {
                    return null;
                }
            }            
        }
        

    }
}
