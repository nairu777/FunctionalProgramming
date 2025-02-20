using FluentAssertions;
using FunctionalProgramming.Chapter1.Listings;

namespace FunctionalProgramming.Chapter1.Tests;

public class Listing3Tests
{
    [Fact]
    public static void Sort_WhenAppliedOnArray_SortOrriginalArray()
    {
        // Arrange
        var original = new int[] { 5, 7, 1 };
        var expectedResult = new int[] { 1, 5, 7 };
        
        // Act
        original.Sort();
        
        // Assert
        original.Should().BeEquivalentTo(expectedResult);
    }
}