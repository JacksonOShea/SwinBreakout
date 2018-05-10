using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;
namespace MyGame
{
    public class Paddle
    {
        private float _x, _y;
        private int _width, _height;
        private int _dx;
        private Bitmap _bitmap;

        //The paddle that is used to hit the ball
        public Paddle()
        {
            _x = 350;
            _y = 550;
            _bitmap = SwinGame.BitmapNamed("Paddle");
            _width = SwinGame.BitmapWidth(_bitmap);
            _height = SwinGame.BitmapHeight(_bitmap);
            _dx = 4;
        }

        //Moves the paddle Right
        public void MoveRight()
        {
            _x = _x + _dx;
        }

        //Moves the paddle Left
        public void MoveLeft()
        {
            _x = _x - _dx;
        }

        public void Draw()
        {
            SwinGame.DrawBitmap(_bitmap, _x, _y);
        }

        //Simply Resets the paddle
        public void Reset()
        {
            _x = 350;
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

        //Bitmap Property
        public Bitmap Bitmap
        {
            get { return Bitmap; }
            set { _bitmap = Bitmap; }
        }
    }
}
