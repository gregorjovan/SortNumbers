using SortNumbers.Application;

namespace SortNumbers.Tests;

public class InsertionSortServiceTests
    {
        [Fact]
        public void Sort_ShouldSortUnsortedArray()
        {
            // Arrange
            var service = new InsertionSortService();
            var input = new[] { 5, 3, 1, 4 };
            var expected = new[] { 1, 3, 4, 5 };

            // Act
            var result = service.Sort(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Sort_ShouldHandleEmptyArray()
        {
            // Arrange
            var service = new InsertionSortService();
            var input = Array.Empty<int>();

            // Act
            var result = service.Sort(input);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Sort_ShouldHandleAlreadySortedArray()
        {
            // Arrange
            var service = new InsertionSortService();
            var input = new[] { 1, 2, 3 };

            // Act
            var result = service.Sort(input);

            // Assert
            Assert.Equal([1, 2, 3], result);
        }
    }
