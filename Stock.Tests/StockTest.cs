using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stock.Tests
{
    [TestClass]
    public class StockTest
    {
        [TestMethod]
        public void shouldReturnMinCurrentPriceTen()
        {
            Decimal minPrice = 10;
            Stock victim = new Stock("Google", 10);

            victim.updatePrice(20);

            Decimal actual = victim.currentPrice;

            Assert.AreEqual(minPrice, actual);
        }
    }
}
