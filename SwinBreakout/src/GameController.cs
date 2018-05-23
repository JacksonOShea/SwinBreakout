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

        public int _score;
        public bool _brickHit;

        //Controls the Game and its flow
        public GameController()
        {
            _brickManager = new BrickManager();
            _collisionManager = new CollisionManager();
            _paddle = new Paddle();
            _ball = new Ball();
            _bricks = _brickManager.CreateBricks();
            _score = 0;
        }


        // New game, re-place ball, paddle and Bricks
        public void StartGame()
        {
            _brickManager.RestoreBricks();
            _paddle.Reset();
            _ball.Reset();
            _score = 0;
        }


        public void CheckCollision()
        {
            //Checks every Brick
            for (int i = 0; i < _bricks.Length; i++)
            {

                //If the ball does hit a brick, increase the score by 1, and move the brick to the left of the screen
                if (_collisionManager.BallHitBrick(_ball, _bricks[i]))
                {
                    _score += 1;
                    _bricks[i].X = -500;
                    _bricks[i].Y = -500;
                    SwinGame.PlaySoundEffect("BrickHit");
                }

                //Returns Brick Hit to false after each check
                _brickHit = false;
            }

            _collisionManager.BallHitPaddle(_ball, _paddle);
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

            //Draws the score
            DrawHeadings();

            SwinGame.RefreshScreen();
        }


        // Draws the Current Headings
        public void DrawHeadings()
        {
            //Draws the Score
            SwinGame.DrawText("Score: " + _score, Color.White, 120, 1);
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

	

