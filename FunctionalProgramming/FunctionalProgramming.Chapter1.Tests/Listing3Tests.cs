using FluentAssertions;
using FunctionalProgramming.Chapter1.Listings;

namespace FunctionalProgramming.Chapter1.Tests;

/// <summary>
///     Non-functional approach: List<T>. Sort sorts the list in place
/// </summary>
public class Listing3Tests
{
    [Fact]
    public void Sort_WhenAppliedOnArray_SortOriginalArray()
    {
        // Arrange
        var original = new[] { 5, 7, 1 };
        var expectedResult = new[] { 1, 5, 7 };
        
        // Act
        original.Sort();
        
        // Assert
        original.Should().BeEquivalentTo(expectedResult);
    }
}