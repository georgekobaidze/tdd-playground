namespace Calculator.Tests;

public class ArithmeticsTests
{
    [Theory]
    [InlineData(3, 6, 9)]
    [InlineData(2.6, 2.8, 5.4)]
    [InlineData(-1.2, 0, -1.2)]
    public void Add_SimpleValuesShouldCalculate(decimal x, decimal y, decimal expected)
    {
        // Arrange
        
        // Act
        var actual = Arithmetics.Add(x, y);

        // Assert
        Assert.Equal(expected, actual);
    }
}