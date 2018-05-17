using System;
using System.Collections.Generic;
using SwinGameSDK;

namespace MyGame
{
    public class BrickManager
    {
        Brick[] _createdBricks;
        
        //Brick Manager COnstructor
        public BrickManager()
        {
            _createdBricks = new Brick[40];
        }

        //Creates ALL Bricks
        public Brick[] CreateBricks()
        {

            for (int i = 0; i <= 9; i++)
            {
                //Creates 10 Red Bricks to be placed along the top row
                _createdBricks[i] = new Brick((5 + (100 * i)), 18, SwinGame.BitmapNamed("RedBrick"));
            }

            for (int i = 10; i <= 19; i++)
            {
                //Creates 10 Yellow Bricks to be placed along the second row from the top
                _createdBricks[i] = new Brick((5 + (100 * (i - 10))), 63, SwinGame.BitmapNamed("YellowBrick"));
            }

            for (int i = 20; i <= 29; i++)
            {
                //Creates 10 Green Bricks to be placed along the third row from the top
                _createdBricks[i] = new Brick((5 + (100 * (i - 20))), 108, SwinGame.BitmapNamed("GreenBrick"));
            }

            for (int i = 30; i <= 39; i++)
            {
                //Creates 10 Blue Bricks to be placed along the bottom row
                _createdBricks[i] = new Brick((5 + (100 * (i - 30))), 153, SwinGame.BitmapNamed("BlueBrick"));
            }

            return _createdBricks;
        }

        //Restores all bricks to their original placements
        public Brick[] RestoreBricks()
        {
            //Clears the entire array of bricks
            Array.Clear(_createdBricks, 0, 39);

            //Creates the bricks once again and returns this to the GameController
            return CreateBricks();
        }


        //Created Bricks Property
        public Brick[] CreatedBricks
        {
            get { return _createdBricks; }
            set { _createdBricks = value; }
        }
    }
}

	

