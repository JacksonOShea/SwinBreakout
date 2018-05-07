using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;
namespace MyGame
{
    class Platform
    {
        private float _x, _y;
        private int _width, _height;
        private Color _color;
        private int SPEED = 4;
        private Rectangle _area;

        public Rectangle Area { get => _area; set => _area = value; }
        public float X { get => _x; set => _x = value; }
        public float Y { get => _y; set => _y = value; }
        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }

        public Platform()
        {
            _x = 350;
            _y = 550;
            _width = 100;
            _height = 20;
            _color = Color.Black;
            _area.X = _x;
            _area.Y = _y;
            _area.Height = _height;
            _area.Width = _width;
        }

        public void MoveRight()
        {
            _x = _x + SPEED;
        }

        public void MoveLeft()
        {
            _x = _x - SPEED;
        }

        public void Draw()
        {
            SwinGame.FillRectangle(_color, _x, _y, _width, _height);
        }

    }
}
