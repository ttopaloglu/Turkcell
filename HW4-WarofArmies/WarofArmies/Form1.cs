using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WarofArmies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Classes.Game Game = null;

        private void starAttack_Click(object sender, EventArgs e)
        {
            if (Game==null)
            {
                Game = new Classes.Game();
            }
            Game.startWar();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.EnemiesAreFighting();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
