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

            GameController _gameController = new GameController();


            //Runs the Game Loop
            do
            {
                //Checks the user's input, Checks the Collision and then Draws the Screen
                _gameController.HandleUserInput();
                _gameController.CheckPause();
                _gameController.CheckCollision();
                _gameController.DrawScreen();
                _gameController.CheckStatus();

            } while (!(SwinGame.WindowCloseRequested() == true));

            SwinGame.ReleaseAllBitmaps();
            SwinGame.ReleaseAllMusic();
        }
    }
}
