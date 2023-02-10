using Account.Business.ExchangeSchool.Models;

namespace Account.Business.ExchangeSchool.Tests
{
    [Parallelizable]
    public class SchoolTests
    {
        [Test]
        public void ShouldCreateShool()
        {
            // Arrange
            var schoolName = "school";

            var priceRanges1 = new List<PriceRange>
            {
                new PriceRange(1, 10, 100),
                new PriceRange(11, 20, 90)
            };
            var priceRanges2 = new List<PriceRange>
            {
                new PriceRange(1, 5, 100),
                new PriceRange(6, 10, 90)
            };
            var courses = new List<Course>
            {
                new Course("course1", priceRanges1.ToArray()),
                new Course("course2", priceRanges2.ToArray())
            };

            // Act
            var school = new School(schoolName, courses.ToArray());

            // Assert
            Assert.That(school.Name, Is.EqualTo(schoolName));
        }
    }
}