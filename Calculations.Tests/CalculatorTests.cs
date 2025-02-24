using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests;

public class CalculatorFixture: IDisposable {
   public Calculator Calc => new();

    public void Dispose()
    {
       // Clean
    }
}

public class CalculatorTests: IDisposable, IClassFixture<CalculatorFixture>
{
   private readonly ITestOutputHelper _testOutputHelper;
   private readonly CalculatorFixture _calculatorFixture;
   private readonly MemoryStream _memoryStream;

   public CalculatorTests(ITestOutputHelper testOutputHelper, CalculatorFixture calculatorFixture)
   {
      _testOutputHelper = testOutputHelper;
      _testOutputHelper.WriteLine("Constructor");
      _calculatorFixture = calculatorFixture;
      _memoryStream = new MemoryStream();
   }

   [Fact]
   public void Add_GivenTwoIntValues_ReturnsInt()
   {
      var calc = new Calculator();
      _testOutputHelper.WriteLine("Executing test!!! Add_GivenTwoIntValues_ReturnsInt");
      var result = calc.Add(1, 2);
      Assert.Equal(3, result);
   }

   [Fact]
   public void AddDouble_GivenTwoDoubleValues_ReturnsDouble()
   {
      var calc = _calculatorFixture.Calc;
      var result = calc.AddDouble(1.2, 3.5);
      Assert.Equal(4.7, result);
   }

   [Fact]
   [Trait("Category", "Fibonacci")]
   public void FiboNumbers_DoesntIncludeZero()
   {
      var calc = _calculatorFixture.Calc;
      Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
   }

   [Fact]
   [Trait("Category", "Fibonacci")]
   public void FiboNumbers_Includes13()
   {
      var calc = _calculatorFixture.Calc;
      Assert.Contains(13, calc.FiboNumbers);
   }

   [Fact]
   [Trait("Category", "Fibonacci")]
   public void FiboNumbers_DoesntInclude4()
   {
      var calc = _calculatorFixture.Calc;
      Assert.DoesNotContain(4, calc.FiboNumbers);
   }

   [Fact]
   [Trait("Category", "Fibonacci")]
   public void FiboNumbers_HasBeen()
   {
      var calc = _calculatorFixture.Calc;
      Assert.Equal([1,1,2,3,5,8,13], calc.FiboNumbers);
   }

   public void Dispose()
   {
      _memoryStream.Close();
   }
}