using Account.Business.ExchangeSchool.Models;

namespace Account.Business.ExchangeSchool.Tests
{
    [Parallelizable]
    internal class PricingTests
    {
        [Test]
        public void ShouldGetPriceRange()
        {
            // Arrange
            var weekQuantity = 100;

            var ranges = new List<PriceRange>
            {
                new PriceRange(10, 100, 5),
                new PriceRange(101, 200, 4)
            };

            // Act
            var selectedRange = Services.Services.FindRange(ranges.ToArray(), weekQuantity);

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(selectedRange.RangeFrom, Is.EqualTo(10));
                Assert.That(selectedRange.RangeTo, Is.EqualTo(100));
                Assert.That(selectedRange.Price, Is.EqualTo(5));
            });
        }
    }
}
