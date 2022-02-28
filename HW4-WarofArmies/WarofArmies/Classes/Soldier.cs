using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarofArmies.Classes
{
    public class Soldier
    {
        System.Windows.Forms.Form.ControlCollection formControls = (System.Windows.Forms.Form.ControlCollection)Application.OpenForms["Form1"].Controls;
        public static int power { get; set; } = 1;
        public double health { get; set; } = 100;
        public Armor armor { get; set; }
        public Weapon weapon { get; set; } 
        public bool isAlive { get; set; }
        public bool isHaveEnemy { get; set; }
        public Soldier enemy;
        public Army myArmy;
        public string soldierName;
        public PictureBox soldierPictureBox;
        public Label soldierLabel;
        public ProgressBar soldierProgressbar;
        public Panel soldierPanel;


        public Soldier(Army myArmy,Weapon weapon,Armor armor)
        {
            this.weapon = weapon;
            this.armor = armor;
            this.myArmy = myArmy;
            soldierName = myArmy.soldierId.ToString();
            myArmy.soldierId++;
            soldierPanelCreate(myArmy.soldierId);
        }

        public void findEnemy()
        {
            enemy = myArmy.findEnemy(this);
            isHaveEnemy = true;
        }

        public void attackToEnemy()
        {
            enemy = weapon.attack(enemy);
            if (enemy.health <= 0)
            {
                enemy.soldierProgressbar.Value = 0;
            }
            else
            {
                enemy.soldierProgressbar.Value = Convert.ToInt32(enemy.health);
            }            
            Console.WriteLine(this.soldierName + " Health Point  : " + this.health.ToString());
            Console.WriteLine(this.soldierName + "My Enemy" + enemy.soldierName);
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                myArmy.deleteEnemy(enemy);
                isHaveEnemy = false;
                findEnemy();                
            }
        }

        public void labelCreate(int soldierNumber)
        {
            Label tempLabel = null;

            tempLabel = new Label();
            tempLabel.Location = new System.Drawing.Point(0, 65);
            tempLabel.Name = "label" + soldierName;
            tempLabel.Size = new System.Drawing.Size(35, 13);
            tempLabel.AutoSize = true;
            tempLabel.Text = soldierName;
            tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            soldierLabel = tempLabel;
        }

        public void progressBarCreate(int soldierNumber)
        {
            ProgressBar tempProgressBar = null;
            tempProgressBar = new ProgressBar();
            tempProgressBar.Location = new System.Drawing.Point(5, 55);
            tempProgressBar.Name = "progressbar" + soldierNumber;
            tempProgressBar.Size = new System.Drawing.Size(40, 10);
            tempProgressBar.Value = 100;
            soldierProgressbar = tempProgressBar;
        }

        public void soldierPanelCreate(int soldierNumber)
        {
            pictureBoxCreate(soldierNumber);
            labelCreate(soldierNumber);
            progressBarCreate(soldierNumber);
            Panel tempPanel = new Panel();
            List<Panel> soldiersPictureboxs = new List<Panel>();
            int soldierPanelx = 50;
            int soldierPpanely = 80;
            int columnNumber = 15;
            

            tempPanel.Controls.Add(soldierPictureBox);
            tempPanel.Controls.Add(soldierLabel);
            tempPanel.Controls.Add(soldierProgressbar);
            tempPanel.Location = new System.Drawing.Point(soldierPanelx * ((soldierNumber-2) % columnNumber), soldierPpanely * ((soldierNumber-2) / columnNumber));
            tempPanel.Name = "panel3" + soldierNumber;
            tempPanel.Size = new System.Drawing.Size(soldierPanelx, soldierPpanely);
            Panel panelControls = (Panel)formControls[myArmy.armyPanelName];
            panelControls.Controls.Add(tempPanel);
            soldierPanel = tempPanel;
        }

        public void pictureBoxCreate(int soldierNumber)
        {
            PictureBox tempPictureBox = null;

            tempPictureBox = new PictureBox();
            tempPictureBox.Image = myArmy.armyPicture;
            tempPictureBox.Location = new System.Drawing.Point(5, 0);
            tempPictureBox.Name = "pictureBox" + soldierName;
            tempPictureBox.Size = new System.Drawing.Size(40, 55);
            tempPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            soldierPictureBox = tempPictureBox;
        }

    }
}
