using System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        public static void Main()
        {
            // Opens Audio in swin game
            SwinGame.OpenAudio();

            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 1005, 600);

            // Load all relevant files
            GameResources.LoadResources();

            //TODO:
            // GameController _gameController = new GameController();


            //Runs the Game Loop
            do
            {
                //TODO:
                // _gameController.HandleUserInput();
                // _gameController.DrawScreen();


            } while (!(SwinGame.WindowCloseRequested() == true));

            SwinGame.ReleaseAllBitmaps();
            SwinGame.ReleaseAllMusic();
        }
    }
}