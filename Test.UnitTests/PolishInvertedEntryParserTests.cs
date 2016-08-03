using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.Nodes;

namespace Test.UnitTests
{
    [TestClass]
    public class PolishInvertedEntryParserTests
    {
        [TestMethod]
        public void Parse_Expect6()
        {
            Assert.AreEqual(PolishInvertedEntryParser.Parse("8 2 5 * + 1 3 2 * + 4 - /").GetDoubleValue(), 6);
        }

        [TestMethod]
        public void Parse_Expect()
        {
            Assert.AreEqual(PolishInvertedEntryParser.Parse("-12 2 /").GetDoubleValue(), -6);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void Parse_ExpectException()
        {
            INode temp = new OperationNode("^");
        }
    }
}
