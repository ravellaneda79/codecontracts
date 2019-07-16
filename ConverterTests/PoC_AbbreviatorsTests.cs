using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoC_Contracts;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace ConverterTests
{
    [TestClass]
    public class PoC_AbbreviatorsTest
    {
        [TestMethod]
        public void GivenEmptyFilename_WhenChange_ThenThrowsException()
        {
            // Arrange
            var sut = new PoC_Abbreviators();
            var anyList = new List<string>();

            Contract.ContractFailed += new EventHandler<ContractFailedEventArgs>(Contract_ContractFailed);

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => sut.Change(string.Empty, anyList));
        }

        static void Contract_ContractFailed(object sender, System.Diagnostics.Contracts.ContractFailedEventArgs e)
        {
            e.SetHandled();
            Assert.Fail("{0}: {1} {2}", e.FailureKind, e.Message, e.Condition);
        }
    }
}
