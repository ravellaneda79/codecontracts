using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoC_Contracts;
using System;

namespace ConverterTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HappyPath()
        {
            // Arrange
            var sut = new CurrentCultureUpperCaseFormatter();
            const string AnyString = "Fake";

            // Act
            var result = sut.Convert(AnyString);

            // Assert
            Assert.AreEqual(AnyString.ToUpper(), result);
        }

        [TestMethod]
        public void GivenNull_WhenConvert_GetEmptyString()
        {
            // Arrange
            var sut = new CurrentCultureUpperCaseFormatter();

            // Act
            Assert.ThrowsException<Exception>(() => sut.Convert(null));
        }
    }
}
