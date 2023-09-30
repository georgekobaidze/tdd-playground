namespace Calculator.Tests;

public class ArithmeticsTests
{
    [Fact]
    public void Add_SimpleValuesShouldCalculate()
    {
        // Arrange
        var expected = 5m;

        // Act
        var actual = Arithmetics.Add(3, 2);

        // Assert
        Assert.Equal(expected, actual);
    }
}