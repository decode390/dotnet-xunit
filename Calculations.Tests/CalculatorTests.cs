using Xunit;
using Xunit.Abstractions;

namespace Calculations.Tests;

public class CalculatorTests: IDisposable
{
   private readonly ITestOutputHelper _testOutputHelper;
   private readonly MemoryStream _memoryStream;

   public CalculatorTests(ITestOutputHelper testOutputHelper)
   {
      _testOutputHelper = testOutputHelper;
      _testOutputHelper.WriteLine("Constructor");
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
      var calc = new Calculator();
      var result = calc.AddDouble(1.2, 3.5);
      Assert.Equal(4.7, result);
   }

   [Fact]
   [Trait("Category", "Fibonacci")]
   public void FiboNumbers_DoesntIncludeZero()
   {
      var calc = new Calculator();
      Assert.All(calc.FiboNumbers, n => Assert.NotEqual(0, n));
   }

   [Fact]
   [Trait("Category", "Fibonacci")]
   public void FiboNumbers_Includes13()
   {
      var calc = new Calculator();
      Assert.Contains(13, calc.FiboNumbers);
   }

   [Fact]
   [Trait("Category", "Fibonacci")]
   public void FiboNumbers_DoesntInclude4()
   {
      var calc = new Calculator();
      Assert.DoesNotContain(4, calc.FiboNumbers);
   }

   [Fact]
   [Trait("Category", "Fibonacci")]
   public void FiboNumbers_HasBeen()
   {
      var calc = new Calculator();
      Assert.Equal([1,1,2,3,5,8,13], calc.FiboNumbers);
   }

   public void Dispose()
   {
      _memoryStream.Close();
   }
}