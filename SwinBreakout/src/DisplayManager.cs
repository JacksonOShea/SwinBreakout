using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
    //The Collision Manager stores no variables, simply checks whether collisions have occured
    public class DisplayManager
    {
        //Display Manager Constructor
        public DisplayManager()
        { }

        //Displays the Lost Screen
        public void DisplayLostScreen()
        {
            SwinGame.FillRectangle(Color.LightBlue, 182, 150, 640, 300);
            SwinGame.DrawRectangle(Color.White, 182, 150, 640, 300);
            SwinGame.DrawBitmap(SwinGame.BitmapNamed("LostScreen"), 202, 150);
            SwinGame.PlaySoundEffect("Dissapoint");
            SwinGame.RefreshScreen();
            SwinGame.Delay(4000);
        }

        //Displays the Lost Screen
        public void DisplayWonScreen()
        {
            SwinGame.FillRectangle(Color.LightBlue, 202, 150, 600, 300);
            SwinGame.DrawRectangle(Color.White, 202, 150, 600, 300);
            SwinGame.DrawBitmap(SwinGame.BitmapNamed("WonScreen"), 202, 150);
            SwinGame.PlaySoundEffect("Celebration");
            SwinGame.RefreshScreen();
            SwinGame.Delay(4000);
        }
    }
}

	

