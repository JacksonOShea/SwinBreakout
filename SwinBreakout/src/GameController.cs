using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
    public class GameController
    {
        public Paddle _paddle;
        //public Ball _ball;
        public Brick[] _bricks;
        public BrickManager _brickManager;
        

        //Controls the Game and its flow
        public GameController()
        {
            _brickManager = new BrickManager();
            _paddle = new Paddle();
        //   _ball = new Ball();
            _bricks = _brickManager.CreateBricks();
        }


        // New game, re-place ball, paddle and Bricks
        public void StartGame()
        {
            _brickManager.RestoreBricks();
            _paddle.Reset();
        //    _ball.Reset();
        }


        // Handles user input
        public void HandleUserInput()
        {
            SwinGame.ProcessEvents();

            if (SwinGame.KeyDown(KeyCode.RightKey) && (_paddle.X < 1005))
            {
                _paddle.MoveRight();
            }
            if (SwinGame.KeyDown(KeyCode.LeftKey) && (_paddle.X > 0))
            {
                _paddle.MoveLeft();
            }
        }

    
        // Displays game state on screen
        public void DrawScreen()
        {
            SwinGame.ClearScreen(SwinGame.ColorBlack());
            
            //Draws the Paddle
            _paddle.Draw();

            //Draws the Bricks
            DrawBricks();

            SwinGame.RefreshScreen();
        }   
        

        //Draws all Bricks
        public void DrawBricks()
        {
            for (int i = 0; i < _bricks.Length; i++)
            {
                _bricks[i].Draw();
            }
        }
    }
}

	

