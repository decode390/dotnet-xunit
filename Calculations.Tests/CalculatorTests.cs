using Xunit;

namespace Calculations.Tests;

public class CalculatorTests
{
    [Fact]
    public void Add_GivenTwoIntValues_ReturnsInt() {
       var calc = new Calculator(); 
       var result = calc.Add(1,2);
       Assert.Equal(3, result);
    }

    [Fact]
    public void AddDouble_GivenTwoDoubleValues_ReturnsDouble() {
       var calc = new Calculator(); 
       var result = calc.AddDouble(1.2, 3.5);
       Assert.Equal(4.7, result);
    }

    [Fact]
    public void FiboNumbers_DoesntIncludeZero() {
      var calc = new Calculator();
      Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
    }

}