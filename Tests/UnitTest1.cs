using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STETools;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var g = new SerialNumberGenerator();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(g.Generate());
            }
        }
    }
}
