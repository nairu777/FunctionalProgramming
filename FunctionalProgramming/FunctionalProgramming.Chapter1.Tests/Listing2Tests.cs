using FluentAssertions;
using FunctionalProgramming.Chapter1.Listings;

namespace FunctionalProgramming.Chapter1.Tests;

public class Listing2Tests
{
    [Theory]
    [InlineData(0, false)]
    [InlineData(1, true)]
    [InlineData(2, false)]
    public static void IsOdd_GivenAPositiveInteger_ReturnTrueIfOdd(int testCase, bool expectedResult)
    {
        // Act
        var result = Listing2.IsOdd(testCase);
        
        // Assert
        result.Should().Be(expectedResult);
    }

    [Fact]
    public static void IsOdd_WhenUsedToFilterAnArray_OnlyReturnOddIntegers()
    {
        // Arrange
        var testArray = new[] { 7, 6, 1 };
        var expectedResult = new[] { 7, 1 };
        
        // Act
        var result = testArray.Where(Listing2.IsOdd);
        
        // Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}