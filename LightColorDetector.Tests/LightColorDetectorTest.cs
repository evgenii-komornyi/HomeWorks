using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LightColorDetector.Tests
{
    [TestClass]
    public class LightColorDetectorTest
    {
        [TestMethod]
        public void testVioletLight()
        {
            LightColorDetector victim = new LightColorDetector();

            String expectedResult = "Violet";
            String actualResult = victim.detect(385);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
