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

    [Theory]
    [InlineData(100, 36, 64)]
    [InlineData(9.2, 10.92, -1.72)]
    [InlineData(11, 0, 11)]
    public void Subtract_SimpleValuesShouldCalculate(decimal x, decimal y, decimal expected)
    {
        // Arrange
        
        // Act
        var actual = Arithmetics.Subtract(x, y);

        // Assert
        Assert.Equal(expected, actual);
    }
}