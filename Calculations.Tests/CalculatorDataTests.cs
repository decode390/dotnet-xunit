using Xunit;

namespace Calculations.Tests;

public class CalculatorDataTests
{
    [Fact]
    public void IsOdd_GivenOddValue_ReturnsTrue()
    {
        var calc = new Calculator();
        var result = calc.IsOdd(1);

        Assert.True(result);
    }

    [Fact]
    public void IsOdd_GivenEvenValue_ReturnsFalse()
    {
        var calc = new Calculator();
        var result = calc.IsOdd(2);

        Assert.False(result);
    }

    // [Theory]
    // [InlineData(1, true)]
    // [InlineData(2, false)]
    // public void IdOdd_TestOddAndEven(int value, bool expected){
    //     var calc = new Calculator();
    //     var result = calc.IsOdd(value);

    //     Assert.Equal(expected, result);
    // }

    [Theory]
    // [MemberData(nameof(TestDataShare.IsOddOrEvenData), MemberType = typeof(TestDataShare))]
    // [MemberData(nameof(TestDataShare.IsOddOrEvenExternalData), MemberType = typeof(TestDataShare))]
    [IsOddOrEvenData]
    public void IdOdd_TestOddAndEven(int value, bool expected){
        var calc = new Calculator();
        var result = calc.IsOdd(value);

        Assert.Equal(expected, result);
    }

}