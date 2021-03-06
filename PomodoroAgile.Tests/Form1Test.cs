using System;
using NUnit.Framework;
using PomodoroAgile;

namespace PomodoroAgile.Tests
{
    [TestFixture]
    public partial class Form1Test
    {
        Form1 target;
        [SetUp]
        public void setup()
        {
            target = new Form1();
        }
        
        [Test, Description("winform test1")]
        public void test1()
        {
            Assert.AreEqual(1, target.myint);
            target.myint = 2;
        }

        [Test, Description("winform test1")]
        public void test2()
        {
            Assert.AreEqual(1, target.myint);
        }
    }

}

