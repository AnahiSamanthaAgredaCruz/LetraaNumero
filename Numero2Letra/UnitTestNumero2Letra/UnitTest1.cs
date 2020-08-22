using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numero2Letra.Controllers;

namespace UnitTestNumero2Letra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConversore()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int numero = 5;
            string esperado = "CINCO";

            //Act

            string resutado = literalController.Literalget(numero);
            //Assert
            Assert.AreEqual(esperado, resutado);


        }
    }
}
