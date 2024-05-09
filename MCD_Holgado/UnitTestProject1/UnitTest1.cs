using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using maximocomundiv;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                int actual = maximocomun.maxcmul_CuatroNumeros(4, 6, 8, 10);
                int esperado = 2;
                Assert.AreEqual(actual,esperado);
           
        }
    }
}
