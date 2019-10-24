using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace UnitTestStack
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPush()
        {
            Stack S = new Stack(1000);
            S.Push(1);
            S.Push(2);
            S.Push(3);
            Assert.AreEqual(3, S.Peek());
            Assert.AreEqual(3, S.Pop());
        }
    }
}
