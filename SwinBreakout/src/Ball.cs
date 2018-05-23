using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;
namespace MyGame
{
    public class Ball
    {
        private float _x, _y;
        private int _width, _height;
        private int _dx, _dy;
        private Bitmap _bmp;

        //The paddle that is used to hit the ball
        public Ball()
        {
            _bmp = SwinGame.BitmapNamed("Ball");
            _width = SwinGame.BitmapWidth(_bmp);
            _height = SwinGame.BitmapHeight(_bmp);

            _x = ((SwinGame.ScreenWidth() - _width) / 2);
            _y = ((SwinGame.ScreenHeight() - _height) / 2);

            _dx = 0;
            _dy = +3;
        }



        //Updates the Ball's Position and checks for collisions against walls
        public void Update()
        {
            Move();
            LimitBoundaries();
        }



        //Moves the paddle Right
        public void Move()
        {
            LimitBoundaries();
            //Added * 3 to make the game faster
            _x = _x + (_dx * 2);
            _y = _y + (_dy * 2);
        }



        //Calculates if the ball has hit either wall or the top of the screen
        public void LimitBoundaries()
        {

            //Revere DX if hit the left side
            if ((_x < 0) && (_dx < 0))
                _dx = -_dx;

            //Reverse DX if hit the Right of the screen
            if ((_x > SwinGame.ScreenWidth() - _width) && (_dx > 0))
                _dx = -_dx;

            //Hit the Top of the Screen
            if ((_y < 13) && (_dy < 0))
                _dy = -_dy;
        }


        //Calculates where the Ball Bounced off a brick
        public void BounceBallOffBrick()
        {
            if ((_y < 189) && (_y > 153))
            {
                _dx = -_dx;
            }

            else if ((_y < 144) && (_y > 108))
            {
                _dy = -_dy;
            }

            else if ((_y < 99) && (_y > 63))
            {
                _dx = -_dx;
            }

            else if ((_y < 54) && (_y > 18))
            {
                _dy = -_dy;
            }

            else
                _dy = -_dy;
        }


        //Changes the Ball's Direction
        public void ChangeDirection(int dxChange, int dyChange)
        {
            _dx = dxChange;
            _dy = dyChange;
        }

        //Draws the Ball
        public void Draw()
        {
            SwinGame.DrawBitmap(_bmp, _x, _y);
        }

        //Simply Resets the paddle
        public void Reset()
        {
            _x = ((SwinGame.ScreenWidth() - _width) / 2);
            _y = ((SwinGame.ScreenHeight() - _height) / 2);
            _dx = 0;
            _dy = +3;
        }

        //X position Property
        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        //Y position property
        public float Y
        {
            get { return _y; }
            set { _y = value; }
        }

        //width property
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        //height property
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        //Dx property (Speed)
        public int Dx
        {
            get { return _dx; }
            set { _dx = value; }
        }

        //Dx property (Speed)
        public int Dy
        {
            get { return _dy; }
            set { _dy = value; }
        }

        //Bitmap Property
        public Bitmap Bmp
        {
            get { return _bmp; }
            set { _bmp = value; }
        }
    }
}