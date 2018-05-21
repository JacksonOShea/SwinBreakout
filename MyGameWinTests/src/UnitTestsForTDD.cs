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
            ballTest.X = paddleTest.X + PaddleSection * 3 ;
            ballTest2.Dy = 1;
            ballTest2.X = paddleTest.X + PaddleSection * 4;
            cM.CalculateBallDirection(paddleTest, ballTest);
            cM.CalculateBallDirection(paddleTest, ballTest2);
            Assert.AreEqual(ballTest2.Dy + ballTest2.Dx, ballTest.Dy - ballTest.Dx);
        }

}