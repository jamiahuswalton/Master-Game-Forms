using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Master_Game_Forms
{
    public partial class MainMenu : Form
    {
        private static double playerHealth; 
        public MainMenu()
        {
            InitializeComponent();
            //TODO: Need to figure out how what need to be initilized, if anything, before starting the game. Maybe I dont need to initilize anything?
        }

        private void WelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            // Set player health
            playerHealth = 100;
            this.Hide();
            Game1 game1 = new Game1();
            game1.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        public static double GetPlayerHealth()
        {
            return playerHealth;
        }
    }
}
