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
        private Bitmap _bitmap;

        //The Ball that is used to hit the ball
        public Ball()
        {
            _x = 500;
            _y = 350;
            _bitmap = SwinGame.BitmapNamed("Ball");
            _width = SwinGame.BitmapWidth(_bitmap);
            _height = SwinGame.BitmapHeight(_bitmap);
            _dx = 0;
            _dy = +3;
        }

        //Updates the Ball's Position and checks for collisions against walls
        public void Update()
        {
            Move();
            LimitBoundaries();
        }

        //Moves the Ball Right
        public void Move()
        {
            _x = _x + _dx;
            _y = _y + _dy;

            LimitBoundaries();
        }

        //Calculates if the ball has hit either wall or the top of the screen
        public void LimitBoundaries()
        {
            if ((_x < 0) || (_x > (1005 - _width)))
            {
                _dx = -_dx;
            }
            if (_y < 0)
            {
                _dy = -_dy;
            }
        }

        public void Draw()
        {
            SwinGame.DrawBitmap(_bitmap, _x, _y);
        }

        //Simply Resets the Ball
        public void Reset()
        {
            _x = 350;
            _y = 350;
            _dx = 0;
            _dy = 3;
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
        public int _Dy
        {
            get { return _dy; }
            set { _dy = value; }
        }

        //Bitmap Property
        public Bitmap Bitmap
        {
            get { return Bitmap; }
            set { _bitmap = Bitmap; }
        }
    }
}
