using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
    public class GameResources
    {

        // Imports bitmaps/images to be used in the game
        private static void LoadBitmaps()
        {
            SwinGame.LoadBitmapNamed("RedBrick", "RedBrick.png");
            SwinGame.LoadBitmapNamed("YellowBrick", "YellowBrick.png");
            SwinGame.LoadBitmapNamed("GreenBrick", "GreenBrick.png");
            SwinGame.LoadBitmapNamed("BlueBrick", "BlueBrick.png");

            //Load Paddle Bitmap
            SwinGame.LoadBitmapNamed("Paddle", "Paddle.png");

            //Load Ball Bitmap
            SwinGame.LoadBitmapNamed("Ball", "Ball.png");
        }

        // Imports sounds to be used in the game
        private static void LoadSounds()
        {
            //Load Sound Effects
            // Recorded by KevanGC - http://soundbible.com/1645-Pling.html
            SwinGame.LoadSoundEffectNamed("BrickHit", "Pling-KevanGC-1485374730.ogg");
            // SwinGame ErrorSound
            SwinGame.LoadSoundEffectNamed("LifeLost", "error.ogg");
            // Recorded by Mike Koenig - http://soundbible.com/1817-Party-Horn.html
            SwinGame.LoadSoundEffectNamed("Celebration", "party_horn-Mike_Koenig-76599891.ogg");
            // Recorded by Joe Lamb - http://soundbible.com/1830-Sad-Trombone.html
            SwinGame.LoadSoundEffectNamed("Dissapoint", "Sad_Trombone-Joe_Lamb-665429450.ogg");
        }


        // Start loading program
        public static void LoadResources()
        {
            LoadBitmaps();
            LoadSounds();
        }
    }
}
