using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame.Tests
{
    [TestClass()]
    public class UnitTests
    {
        public void Initialization()
        {
            SwinGame.OpenGraphicsWindow("GameMain", 1005, 600);
        }


        //----------------------------------------------------------------
        //----------------------------------------------------------------
        //-------------------- Kai Leung, LUI (EDDIE) --------------------
        //----------------------------------------------------------------
        //----------------------------------------------------------------


        [TestMethod()]
        public void PaddleMoveLeft()
        {
            Paddle TestPaddle;
            TestPaddle = new Paddle();
            TestPaddle.MoveLeft();
            Assert.AreEqual(490, TestPaddle.X);
        }

        [TestMethod()]
        public void PaddleMoveRight()
        {
            Paddle TestPaddle;
            TestPaddle = new Paddle();
            TestPaddle.MoveRight();
            Assert.AreEqual(514, TestPaddle.X);
        }

        [TestMethod()]
        public void CheckSpeedFarEnds()
        {
            Paddle paddleTest = new Paddle();
            Ball ballTest = new Ball();
            Ball ballTest2 = new Ball();
            CollisionManager cM = new CollisionManager();
            paddleTest.Width = 60;
            int PaddleSection = (paddleTest.Width / 6);
            ballTest.Dy = 1;
            ballTest.X = paddleTest.X + PaddleSection * 1;
            ballTest2.Dy = 1;
            ballTest2.X = paddleTest.X + PaddleSection * 6;
            cM.CalculateBallDirection(paddleTest, ballTest);
            cM.CalculateBallDirection(paddleTest, ballTest2);
            Assert.AreEqual(ballTest2.Dy + ballTest2.Dx, ballTest.Dy - ballTest.Dx);
        }

        [TestMethod()]
        public void CheckSpeedMiddlePortion()
        {
            Paddle paddleTest = new Paddle();
            Ball ballTest = new Ball();
            Ball ballTest2 = new Ball();
            CollisionManager cM = new CollisionManager();
            paddleTest.Width = 60;
            int PaddleSection = (paddleTest.Width / 6);
            ballTest.Dy = 1;
            ballTest.X = paddleTest.X + PaddleSection * 2;
            ballTest2.Dy = 1;
            ballTest2.X = paddleTest.X + PaddleSection * 5;
            cM.CalculateBallDirection(paddleTest, ballTest);
            cM.CalculateBallDirection(paddleTest, ballTest2);
            Assert.AreEqual(ballTest2.Dy + ballTest2.Dx, ballTest.Dy - ballTest.Dx);
        }

        [TestMethod()]
        public void CheckSpeedCentrePortion()
        {
            Paddle paddleTest = new Paddle();
            Ball ballTest = new Ball();
            Ball ballTest2 = new Ball();
            CollisionManager cM = new CollisionManager();
            paddleTest.Width = 60;
            int PaddleSection = (paddleTest.Width / 6);
            ballTest.Dy = 1;
            ballTest.X = paddleTest.X + PaddleSection * 3;
            ballTest2.Dy = 1;
            ballTest2.X = paddleTest.X + PaddleSection * 4;
            cM.CalculateBallDirection(paddleTest, ballTest);
            cM.CalculateBallDirection(paddleTest, ballTest2);
            Assert.AreEqual(ballTest2.Dy + ballTest2.Dx, ballTest.Dy - ballTest.Dx);
        }


        //----------------------------------------------------------------
        //----------------------------------------------------------------
        //-------------------- HARSHIT TOMAR -----------------------------
        //----------------------------------------------------------------
        //----------------------------------------------------------------

        [TestMethod()]
        public void BallHitPaddleFarLeft()
        {
            Paddle paddleTest = new Paddle();
            Ball ballTest = new Ball();
            CollisionManager cM = new CollisionManager();
            paddleTest.Width = 60;
            int PaddleSection = (paddleTest.Width / 6);
            ballTest.Dy = 1;
            ballTest.X = paddleTest.X + PaddleSection;
            cM.CalculateBallDirection(paddleTest, ballTest);
            Assert.AreEqual(-5, ballTest.Dx);
        }

        [TestMethod()]
        public void BallHitPaddleMiddleLeft()
        {
            Paddle paddleTest = new Paddle();
            Ball ballTest = new Ball();
            CollisionManager cM = new CollisionManager();
            paddleTest.Width = 60;
            int PaddleSection = (paddleTest.Width / 6);
            ballTest.Dy = 1;
            ballTest.X = paddleTest.X + PaddleSection * 2;
            cM.CalculateBallDirection(paddleTest, ballTest);
            Assert.AreEqual(-3, ballTest.Dx);
        }

        [TestMethod()]
        public void BallHitPaddleCentreLeft()
        {
            Paddle paddleTest = new Paddle();
            Ball ballTest = new Ball();
            CollisionManager cM = new CollisionManager();
            paddleTest.Width = 60;
            int PaddleSection = (paddleTest.Width / 6);
            ballTest.Dy = 1;
            ballTest.X = paddleTest.X + PaddleSection * 3;
            cM.CalculateBallDirection(paddleTest, ballTest);
            Assert.AreEqual(-1, ballTest.Dx);
        }

        [TestMethod()]
        public void BallHitPaddleCentreRight()
        {
            Paddle paddleTest = new Paddle();
            Ball ballTest = new Ball();
            CollisionManager cM = new CollisionManager();
            paddleTest.Width = 60;
            int PaddleSection = (paddleTest.Width / 6);
            ballTest.Dy = 1;
            ballTest.X = paddleTest.X + PaddleSection * 4;
            cM.CalculateBallDirection(paddleTest, ballTest);
            Assert.AreEqual(1, ballTest.Dx);
        }
        [TestMethod()]
        public void BallHitPaddleMiddleRight()
        {
            Paddle paddleTest = new Paddle();
            Ball ballTest = new Ball();
            CollisionManager cM = new CollisionManager();
            paddleTest.Width = 60;
            int PaddleSection = (paddleTest.Width / 6);
            ballTest.Dy = 1;
            ballTest.X = paddleTest.X + PaddleSection * 5;
            cM.CalculateBallDirection(paddleTest, ballTest);
            Assert.AreEqual(3, ballTest.Dx);
        }


        [TestMethod()]
        public void BallHitPaddleFarRight()
        {
            Paddle paddleTest = new Paddle();
            Ball ballTest = new Ball();
            CollisionManager cM = new CollisionManager();
            paddleTest.Width = 60;
            int PaddleSection = (paddleTest.Width / 6);
            ballTest.Dy = 1;
            ballTest.X = paddleTest.X + PaddleSection * 6;
            cM.CalculateBallDirection(paddleTest, ballTest);
            Assert.AreEqual(5, ballTest.Dx);

        }



        [TestMethod()]
        public void BallResetsAfterLoss()
        {
            GameController gC = new GameController();
            gC._ball.Y = SwinGame.ScreenHeight() + gC._ball.Height + 1;
            gC.CheckLost();
            Assert.AreEqual(350, gC._ball.Y);
        }

        [TestMethod()]
        public void PaddleResetsAfterLoss()
        {
            GameController gC = new GameController();
            gC._ball.Y = SwinGame.ScreenHeight() + gC._ball.Height + 1;
            gC.CheckLost();
            Assert.AreEqual(502, gC._paddle.X);
        }


        [TestMethod()]
        public void BrickManagerCreateBricks()
        {
            BrickManager bM = new BrickManager();
            Assert.AreEqual(40, bM.CreatedBricks.Length);
        }

        [TestMethod()]
        public void bricksresetsafterloss()
        {
            GameController gc = new GameController();
            gc._ball.y = SwinGame.ScreenHeight() + gc._ball.Height + 1;
            gc.CheckLost();
            Assert.AreEqual(40, gc._bricks.Length);
        }

        

    }
}