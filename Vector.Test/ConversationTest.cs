using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vector.Velocity;

namespace Vector.Test
{
    [TestClass]
    public class ConversationTest
    {
        [TestMethod]
        public void CanConvertFromMsToKm()
        {
            double expected = 36;
            int testFixture = 10;
            double actual = Math.Round(Conversation.ConvertFromMsToKm(testFixture), 0);

            Assert.AreEqual(expected, actual);
        }
    }
}