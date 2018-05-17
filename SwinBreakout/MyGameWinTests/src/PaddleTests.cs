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
    public class PaddleTests
    {
        [TestMethod()]
        public void MoveLeftTest()
        {
            Paddle TestPaddle;
            TestPaddle = new Paddle();


            TestPaddle.MoveLeft();
            Assert.AreEqual(-12, TestPaddle.X);
        }
    }
}