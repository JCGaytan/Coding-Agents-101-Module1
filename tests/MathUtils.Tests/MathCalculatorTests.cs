using MathUtils;
using Xunit;

namespace MathUtils.Tests;

public class MathCalculatorTests
{
    // --- Add ---
    [Fact]
    public void Add_PositiveNumbers_ReturnsSum()
    {
        Assert.Equal(15, MathCalculator.Add(10, 5));
    }

    [Fact]
    public void Add_NegativeNumbers_ReturnsSum()
    {
        Assert.Equal(-3, MathCalculator.Add(-1, -2));
    }

    [Fact]
    public void Add_WithZero_ReturnsSameNumber()
    {
        Assert.Equal(7, MathCalculator.Add(7, 0));
    }

    // --- Subtract ---
    [Fact]
    public void Subtract_PositiveNumbers_ReturnsDifference()
    {
        Assert.Equal(5, MathCalculator.Subtract(10, 5));
    }

    [Fact]
    public void Subtract_ResultIsNegative_ReturnsNegative()
    {
        Assert.Equal(-3, MathCalculator.Subtract(2, 5));
    }

    // --- Multiply (BUG: currently uses division instead of multiplication) ---
    [Fact]
    public void Multiply_PositiveNumbers_ReturnsProduct()
    {
        Assert.Equal(50, MathCalculator.Multiply(10, 5));
    }

    [Fact]
    public void Multiply_ByZero_ReturnsZero()
    {
        Assert.Equal(0, MathCalculator.Multiply(99, 0));
    }

    [Fact]
    public void Multiply_NegativeNumbers_ReturnsPositiveProduct()
    {
        Assert.Equal(6, MathCalculator.Multiply(-2, -3));
    }

    // --- Divide ---
    [Fact]
    public void Divide_PositiveNumbers_ReturnsQuotient()
    {
        Assert.Equal(2, MathCalculator.Divide(10, 5));
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => MathCalculator.Divide(10, 0));
    }

    [Fact]
    public void Divide_ReturnsDecimalResult()
    {
        Assert.Equal(2.5, MathCalculator.Divide(5, 2));
    }
}
