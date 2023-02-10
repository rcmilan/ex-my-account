using Account.Domain.Models;

namespace Account.Domain.Tests
{
    [Parallelizable]
    public class UserTest
    {
        [Test]
        [TestCase("name", "email@email.com", false)]
        [TestCase("name", "", true)]
        public void ShouldCreateUserAndCheckEmail(string name, string email, bool shouldThrowException)
        {
            // Act
            // Arrange
            // Assert
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new MockUser(name, email));
            }
            else
                Assert.Pass();
        }

        [Test]
        [TestCase("name", "email@email.com", false)]
        [TestCase("", "email@email.com", true)]
        public void ShouldCreateUserAndCheckName(string name, string email, bool shouldThrowException)
        {
            // Act
            // Arrange
            // Assert
            if (shouldThrowException)
            {
                Assert.Throws<ArgumentException>(() => new MockUser(name, email));
            }
            else
                Assert.Pass();
        }

        [Test]
        [TestCase("name", "email@email.com", true)]
        [TestCase("name", "email@email.com", false)]
        public void ShouldCreateUserAndToogleIsActive(string name, string email, bool isActive)
        {
            // Arrange
            var user = new MockUser(name, email);

            // Act
            if (user.IsActive != isActive)
                user.ToggleIsActive();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.That(user.Name, Is.EqualTo(name));
                Assert.That(user.Email, Is.EqualTo(email));
                Assert.That(user.IsActive, Is.EqualTo(isActive));
            });
        }
    }

    internal class MockUser : BaseUser
    {
        public MockUser(string name, string email) : base(name, email)
        {
        }
    }
}