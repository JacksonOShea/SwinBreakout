using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
    public class GameController
    {
        public Paddle _paddle;
        public Ball _ball;
        public Brick[] _bricks;
        public BrickManager _brickManager;
        public CollisionManager _collisionManager;
        

        //Controls the Game and its flow
        public GameController()
        {
            _brickManager = new BrickManager();
            _collisionManager = new CollisionManager();
            _paddle = new Paddle();
            _ball = new Ball();
            _bricks = _brickManager.CreateBricks();
        }


        // New game, re-place ball, paddle and Bricks
        public void StartGame()
        {
            _brickManager.RestoreBricks();
            _paddle.Reset();
            _ball.Reset();
        }


        public void CheckCollision()
        {
            _collisionManager.BallHitBrick(_ball, _bricks);
            _collisionManager.BallHitPaddle(_ball, _paddle);

            CheckLost();
        }


        // Handles user input
        public void HandleUserInput()
        {
            SwinGame.ProcessEvents();

            //Checks if the paddle has been moved
            if (SwinGame.KeyDown(KeyCode.RightKey) && ((_paddle.X + _paddle.Width) < 1005))
            {
                _paddle.MoveRight();
            }
            if (SwinGame.KeyDown(KeyCode.LeftKey) && (_paddle.X > 0))
            {
                _paddle.MoveLeft();
            }

            //Updates the ball
            //Change this to implement levels
            _ball.Update();
        }


    
        // Displays game state on screen
        public void DrawScreen()
        {
            SwinGame.ClearScreen(SwinGame.ColorBlack());
            
            //Draws the Paddle
            _paddle.Draw();

            //Draws the Ball
            _ball.Draw();

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

        //Checks if the player has lost
        public void CheckLost()
        {
            //Add Remove Life
            //if (_ball.Y > SwinGame.ScreenHeight() + _ball.Height)
            {

            }
        }
    }
}

	

