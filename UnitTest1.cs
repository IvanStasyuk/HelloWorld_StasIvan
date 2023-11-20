using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HelloWorldTest_StasIvan
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello World!";

        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld_StasIvan.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
    [TestClass]
    public class UnitTest2
    {
        private const string Expected2 = "Goodbye World!";

        [TestMethod]
        public void TestMethod2()
        {
            using (var sq = new StringWriter())
            {
                Console.SetOut(sq);
                HelloWorld_StasIvan.SayGoodBye.Main2();

                var result2 = sq.ToString().Trim();
                Assert.AreEqual(Expected2, result2);
            }
        }
    }
}
