using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vector.Velocity;

namespace Vector.Test
{
    [TestClass]
    public class VelocityTest
    {
        [TestMethod]
        public void SpeedOfLightInMS()
        {
            int expected = Constants.C;
            int actual = 299792458;

            Assert.AreEqual(expected, actual);
        }
    }
}
