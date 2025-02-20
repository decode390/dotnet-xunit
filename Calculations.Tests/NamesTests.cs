using Xunit;

namespace Calculations.Tests;
public class NamesTests
{
    [Fact]
    public void MakeFullNameTest()
    {
        var names = new Names();
        var result = names.MakeFullName("Aref", "Karimi");
        Assert.Equal("Aref Karimi", result, ignoreCase: true);
        Assert.Contains("Aref", result, StringComparison.InvariantCultureIgnoreCase);
        Assert.StartsWith("Aref", result);
        Assert.EndsWith("Karimi", result);
        Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
    }
}