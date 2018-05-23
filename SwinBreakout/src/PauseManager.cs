using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
    public class PauseManager
    {

        // Start loading program
        public PauseManager()
        {
        }

        public void DrawPauseScreen()
        {
            //Draws the outline of the pause menu and sets borders
            SwinGame.FillRectangle(Color.LightBlue, 342, 150, 320, 300);
            SwinGame.DrawRectangle(Color.Black, 342, 150, 320, 300);

            //Draws the text for the game and level options
            SwinGame.DrawBitmap("PauseTitle", 305, 170);
            SwinGame.DrawBitmap("PauseOptions", 342, 250);

            //Shows selection dots
            SwinGame.FillCircle(Color.Gray, 385, 312, 10);
            SwinGame.FillCircle(Color.Gray, 385, 400, 10);
        }


        //Shows all the Pause Options
        public void ShowPauseOptions(int PauseSelection)
        {
            if (PauseSelection == 1)
                SwinGame.FillCircle(Color.Yellow, 385, 312, 8);

            if (PauseSelection == 2)
                SwinGame.FillCircle(Color.Yellow, 385, 400, 8);
        }

        //Enables you to change the pause selection
        public int ChangePauseSelection(int PauseSelection)
        {
            SwinGame.ProcessEvents();

            if ((SwinGame.KeyTyped(KeyCode.UpKey)) && (PauseSelection > 1))
                return (PauseSelection - 1);

            if ((SwinGame.KeyTyped(KeyCode.DownKey)) && (PauseSelection < 2))
                return (PauseSelection + 1);

            else
                return PauseSelection;
        }
    }
}
