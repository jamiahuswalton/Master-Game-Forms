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
    public partial class Game1 : Form
    {
        public Game1()
        {
            InitializeComponent();
        }

        private void Game1_Load(object sender, EventArgs e)
        {
            string playerHealthPoints = MainMenu.GetPlayerHealth().ToString();
            this.HealthLabel.Text = "Health: " + playerHealthPoints;
        }
    }
}
