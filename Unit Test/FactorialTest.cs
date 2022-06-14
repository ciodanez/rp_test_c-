using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program.Functions;

namespace Unit_Test
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void Factorial_FlujoNormal()
        {
            //arrange
            int num = 3;
            int expected = 6;

            //act
            int actual = Calculos.Factorial(num);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}