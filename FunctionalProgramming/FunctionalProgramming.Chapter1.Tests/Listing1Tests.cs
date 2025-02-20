using FluentAssertions;
using FunctionalProgramming.Chapter1.Listings;

namespace FunctionalProgramming.Chapter1.Tests;

public class Listing1Tests
{
    [Theory]
    [InlineData(-2)]
    [InlineData(0)]
    [InlineData(2)]
    public void Triple_WhenGivenInt_MultiplyByThree(int testCase)
    {
        // Arrange
        var expectedResult = testCase * 3;
        
        // Act
        var result = Listing1.Triple(testCase);
        
        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public void Triple_WhenUsedOnArray_MultiplyAllValuesByThree()
    {
        // Arrange
        var range = Enumerable.Range(1, 3);
        var expectedResult = new[] {3, 6, 9};
        
        // Act
        var result = range.Select(Listing1.Triple);
        
        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}