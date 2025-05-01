using FunctionalProgramming.Chapter1.Listings;

namespace FunctionalProgramming.Chapter1.Tests;

/// <summary>
///     Mutating state from concurrent processes
/// </summary>
public class Listing4Tests
{
    [Fact]
    public void ExecuteTask1And2_WhenInvoke_ReturnNothing()
    {
        // Arrange
        var nums = Enumerable.Range(-10000, 20001).Reverse().ToArray();
        
        // Act
        Listing4.ExecuteTask1And2(nums);
    }
    
    [Fact]
    public void ExecuteTask1And3_WhenInvoke_ReturnNothing()
    {
        // Arrange
        var nums = Enumerable.Range(-10000, 20001).Reverse().ToArray();
        
        // Act
        Listing4.ExecuteTask1And3(nums);
    }
}