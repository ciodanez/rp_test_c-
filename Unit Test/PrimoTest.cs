using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program.Functions;

namespace Unit_Test
{
    [TestClass]
    public class CalculosTest
    {
        [TestMethod]
        public void Primo_FlujoNormal()
        {
            //arrange
            int num = 4;
            bool expected = false;

            //act
            bool actual = Calculos.Primo(num);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Primo_FlujoAlternativo()
        {
            //arrange
            int num = 1;
            bool expected = false;

            //act
            bool actual = Calculos.Primo(num);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}