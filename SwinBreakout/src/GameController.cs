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
        public PauseManager _pauseManager;
        public DisplayManager _displayManager;
        public int _score;
        public bool _brickHit;
        public bool _paused;


        //Controls the Game and its flow
        public GameController()
        {
            _pauseManager = new PauseManager();
            _brickManager = new BrickManager();
            _collisionManager = new CollisionManager();
            _displayManager = new DisplayManager();
            _paddle = new Paddle();
            _ball = new Ball();
            _bricks = _brickManager.CreateBricks();
            _score = 0;
            _paused = false;
        }


        // New game, re-place ball, paddle and Bricks
        public void StartGame()
        {
            //Shows "Game Now Starting Screen"
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

        public void CheckStatus()
        {
            CheckWon();
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


            //Checks if the game is paused
            if (SwinGame.KeyTyped(KeyCode.EscapeKey))
            {
                _paused = true;
            }

            //Updates the ball
            //Change this to implement levels
            _ball.Update();
        }


        //Draws the Pause Menu
        public void CheckPause()
        {
            int PauseSelection = 1;
            if (_paused)
            {
                do
                {
                    _pauseManager.DrawPauseScreen();
                    _pauseManager.ShowPauseOptions(PauseSelection);

                    PauseSelection = _pauseManager.ChangePauseSelection(PauseSelection);
                    SwinGame.RefreshScreen(60);


                    if ((SwinGame.KeyTyped(KeyCode.ReturnKey)) && PauseSelection == 2)
                    {
                        StartGame();
                        _paused = false;
                    }
                        
                } while (!(SwinGame.KeyTyped(KeyCode.EscapeKey)) && !(SwinGame.KeyTyped(KeyCode.ReturnKey)) && !(SwinGame.WindowCloseRequested()));

                _paused = false;
            }
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
            if (_ball.Y > (SwinGame.ScreenHeight() + _ball.Height))
            {
                _displayManager.DisplayLostScreen();
                StartGame();
            }
        }

        //Checks if the player has lost
        public void CheckWon()
        {
            if (_score == 40)
            {
                _displayManager.DisplayWonScreen();
                StartGame();
            }
        }
    }
}

	

