using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame  
{
    public class Brick
    {
        private int _x, _y;
        private int _width, _height;
        private Bitmap _bmp;

        public Brick(int _X, int _Y, Bitmap _Bmp)
        {
            _x = _X;
            _y = _Y;
            _bmp = _Bmp;

            _width = SwinGame.BitmapWidth(_bmp);
            _height = SwinGame.BitmapHeight(_bmp);
        }

        public void Draw()
        {
            SwinGame.DrawBitmap(_bmp, _x, _y);
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Bitmap Bmp
        {
            get { return _bmp; }
            set { _bmp = Bmp; }
        }
    }
}
