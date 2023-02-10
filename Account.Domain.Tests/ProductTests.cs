namespace Account.Domain.Tests
{
    internal class ProductTests
    {
        [Test]
        public void ShouldCreateProduct()
        {
            // Arrange
            var name = "product";

            // Act
            var p = new MockProduct(name);

            // Assert
            Assert.That(p.Name, Is.EqualTo(name));
        }

        [Test]
        public void ShouldNotCreateProduct()
        {
            // Arrange
            var name = "";

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => new MockProduct(name));
        }
    }

    internal class MockProduct : BaseProduct
    {
        public MockProduct(string name) : base(name)
        {
        }
    }
}