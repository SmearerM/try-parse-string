using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TPS.ConsoleApp;

namespace TPS.Test
{
    [TestClass]
    public class TryParseAsTests
    {
        [TestMethod]
        public void NullValue()
        {
            String value = null;
            Object parsed = null;
            var isParsed = value.TryParseAs(ref parsed);
            Assert.IsFalse(isParsed);
        }

        [TestMethod]
        public void ParseInt32_BlankString()
        {
            String value = "";
            Int32 parsedValue = -1;
            var isParsed = value.TryParseAs(ref parsedValue);
            Assert.IsFalse(isParsed);
            Assert.AreEqual(parsedValue, -1);
        }

        [TestMethod]
        public void ParseInt32_Value()
        {
            String value = "123";
            Int32 parsedValue = 0;
            var isParsed = value.TryParseAs(ref parsedValue);
            Assert.IsTrue(isParsed);
            Assert.AreEqual(parsedValue, 123);
        }

    }
}
