using Master_Game_Forms.Global;
using System.Windows.Forms;

namespace Master_Game_Forms.Managers
{
    class InputManager
    {
        public InputCommand GetMoveCommand(string moveKey)
        {
            if (moveKey.Equals("A"))
            {
                return InputCommand.MoveLeft;
            }
            else if (moveKey.Equals("S"))
            {
                return InputCommand.MoveDown;
            }
            else if (moveKey.Equals("D"))
            {
                return InputCommand.MoveRight;
            }
            else if (moveKey.Equals("W"))
            {
                return InputCommand.MoveUp;
            }
            else
            {
                return InputCommand.Unknown;
            }
        }
    }
}
