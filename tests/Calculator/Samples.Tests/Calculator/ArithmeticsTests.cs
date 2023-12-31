﻿using Samples.Calculator;

namespace Samples.Tests.Calculator;

public class ArithmeticsTests
{
    [Theory]
    [InlineData(3, 6, 9)]
    [InlineData(2.6, 2.8, 5.4)]
    [InlineData(-1.2, 0, -1.2)]
    public void Add_WhenAddingDecimalValues_ShouldCalculateSum(decimal x, decimal y, decimal expected)
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
    public void Subtract_WhenSubtractingDecimalValues_ShouldCalculateDifference(decimal x, decimal y, decimal expected)
    {
        // Arrange
        
        // Act
        var actual = Arithmetics.Subtract(x, y);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(8, 4, 32)]
    [InlineData(2.21, 23.78, 52.5538)]
    [InlineData(-12, 2.5, -30)]
    [InlineData(3.2, -2.99, -9.568)]
    [InlineData(0, -2.99, 0)]
    [InlineData(-5, 0, 0)]
    public void Multiply_WhenMultiplyingDecimalValues_ShouldCalculateProduct(decimal x, decimal y, decimal expected)
    {
        // Arrange
        
        // Act
        var actual = Arithmetics.Multiply(x, y);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(8, 4, 2)]
    [InlineData(-10, 2, -5)]
    [InlineData(0, 10, 0)]
    public void Divide_WhenDividingDecimalValues_ShouldCalculateQuotient(decimal x, decimal y, decimal expected)
    {
        // Arrange
        
        // Act
        var actual = x / y;

        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 0)]
    [InlineData(-15, 0)]
    [InlineData(2.39, 0)]
    public void Divide_WhenDivisorIsZero_ShouldThrowDivideByZeroException(decimal x, decimal y)
    { 
        // Assert
        Assert.Throws<DivideByZeroException>(() => Arithmetics.Divide(x, y));
    }
}