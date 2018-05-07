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
        private Color _color;
        private float _x, _y;
        private int _width, _height;
        private int _health;
        private Rectangle _area;

        public Rectangle Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public float X
        {
            get { return _x; }
            set { _x = value; }
        }

        public float Y
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
        
        public Brick(Color clr,float x,float y,int w,int h,int health)
        {
            _color = clr;
            _x = x;
            _y = y;
            _width = w;
            _height = h;
            _health = health;
            _area.X = _x;
            _area.Y = _y;
            _area.Height = _height;
            _area.Width = _width;
        }

        public void Random()
        {
            _color = SwinGame.RandomRGBColor(255);
        }
        
        public void ReduceHealth()
        {
            _health = _health - 1;
        }

        public void Draw()
        {
            SwinGame.FillRectangle(_color, _x, _y, _width, _height);
        }

        public bool IsAt(Point2D pt) //SwinGame.PointInRect()  // PointInRect() 
        {
            return SwinGame.PointInRect(pt,_x,_y,_width,_height);
        }
    }
}
