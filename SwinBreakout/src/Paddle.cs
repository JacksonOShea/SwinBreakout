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
        private int _x, _y;
        private int _width, _height;
        private int _dx;
        private Bitmap _bmp;

        //The paddle that is used to hit the ball
        public Paddle()
        {
            _bmp = SwinGame.BitmapNamed("Paddle");
            _width = SwinGame.BitmapWidth(_bmp);
            _x = ((SwinGame.ScreenWidth() - _width) / 2);
            _y = 550;
            _height = SwinGame.BitmapHeight(_bmp);
            _dx = 4;
        }

        //Moves the paddle Right
        public void MoveRight()
        {
                        //Multiplied by 3 to make the game faster and for later levels
            _x = _x + (_dx * 3);
        }

        //Moves the paddle Left
        public void MoveLeft()
        {
                        //Multiplied by 3 to make the game and for later levels
            _x = _x - (_dx * 3);
        }

        public void Draw()
        {
            SwinGame.DrawBitmap(_bmp, _x, _y);
        }

        //Simply Resets the paddle
        public void Reset()
        {
            _x = ((SwinGame.ScreenWidth() - _width) / 2);
            _y = 550;
        }


        //X position Property
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        //Y position property
        public int Y
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
        public Bitmap Bmp
        {
            get { return _bmp; }
            set { _bmp = value; }
        }
    }
}
