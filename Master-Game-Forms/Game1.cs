using Master_Game_Forms.Global;
using Master_Game_Forms.Managers;
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
        InputManager inputManager;
        public Game1()
        {
            InitializeComponent();
            InitializationGameComponents();
        }

        private void InitializationGameComponents()
        {
            inputManager = new InputManager();
        }

        private void Game1_Load(object sender, EventArgs e)
        {
            string playerHealthPoints = MainMenu.GetPlayerHealth().ToString();
            this.HealthLabel.Text = "Health: " + playerHealthPoints;
        }

        private void Is_Move_Key_Down()
        {

        }

        private void Game1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string userKeyPress = e.KeyChar.ToString().ToUpper();
            
            InputCommand userCommand = inputManager.GetMoveCommand(userKeyPress);
            if (userCommand == InputCommand.MoveDown)
            {
                MessageBox.Show("Move down");
                // Add something when command is pressed
            }
            else if (userCommand == InputCommand.MoveUp)
            {
                MessageBox.Show("Move up");
                // Add something when command is pressed
            }
            else if (userCommand == InputCommand.MoveLeft)
            {
                MessageBox.Show("Move left");
                // Add something when command is pressed
            }
            else if (userCommand == InputCommand.MoveRight)
            {
                MessageBox.Show("Move right");
                // Add something when command is pressed
            }
            else
            {
                if(userCommand == InputCommand.Unknown)
                {
                    // This means that the user command is unknown. 
                }
            }
        }
    }
}
