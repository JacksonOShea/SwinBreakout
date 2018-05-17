using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Tests
{
    [TestClass()]
    public class BallTests
    {
        [TestMethod()]
        public void ResetTest()
        {
            Ball TestBall = new Ball();
            TestBall.Reset();
            Assert.AreEqual(350, TestBall.Y);
        }

        [TestMethod()]
        public void MoveTest()
        {
            Ball TestBall = new Ball();
            TestBall.Reset();
            TestBall.Update();
            Assert.AreEqual(359, TestBall.Y);
        }
    }
}