using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
    //The Collision Manager stores no variables, simply checks whether collisions have occured
    public class CollisionManager
    {
        //Brick Manager COnstructor
        public CollisionManager()
        { }
            

        //Checks if the Ball has hit a brick
        public bool BallHitBrick(Ball _ball, Brick _brick)
        {
            if (SwinGame.BitmapCollision(_brick.Bmp, _brick.X, _brick.Y, _ball.Bmp, _ball.X, _ball.Y))
            {
                _ball.BounceBallOffBrick();
                return true;
            }
            else
                return false;
        }


        //Checks if the Ball has hit the paddle
        public void BallHitPaddle(Ball _ball, Paddle _paddle)
        {
            if (SwinGame.BitmapCollision(_paddle.Bmp, _paddle.X, _paddle.Y, _ball.Bmp, _ball.X, _ball.Y))
            {
                CalculateBallDirection(_paddle, _ball);
            }         
        }



        //Calculates where the Ball will bounce off the paddle
        public void CalculateBallDirection(Paddle _paddle, Ball _ball)
        {
            int PaddleSection = (_paddle.Width / 6);


            //Checks if the ball is going downwards
            if (_ball.Dy > 0)
            {
                //If the ball hits the first sixth of the paddle
                if (_ball.X <= (_paddle.X + PaddleSection))
                {
                    _ball.ChangeDirection(-5, -1);
                }

                //If the Ball hits the second sixth of the paddle
                else if ((_ball.X > (_paddle.X + PaddleSection)) && (_ball.X <= _paddle.X + (PaddleSection * 2)))
                {
                    _ball.ChangeDirection(-3, -2);
                }

                //If the ball hits the third sixth of the paddle
                else if ((_ball.X > (_paddle.X + (PaddleSection * 2))) && (_ball.X <= (_paddle.X + (PaddleSection * 3))))
                {
                    _ball.ChangeDirection(-1, -3);
                }

                //If the ball hits the fourth sixth of the paddle
                else if ((_ball.X > (_paddle.X + (PaddleSection * 3))) && (_ball.X <= (_paddle.X + (PaddleSection * 4))))
                {
                    _ball.ChangeDirection(1, -3);
                }

                //If the ball hits the fifth sixth of the paddle
                else if ((_ball.X > (_paddle.X + (PaddleSection * 4))) && (_ball.X <= (_paddle.X + (PaddleSection * 5))))
                {
                    _ball.ChangeDirection(3, -2);
                }

                //If the ball hits the last sixth of the paddle
                else if (_ball.X > (_paddle.X + (PaddleSection * 5)))
                {
                    _ball.ChangeDirection(5, -1);
                }
            }
        }
    }
}

	

