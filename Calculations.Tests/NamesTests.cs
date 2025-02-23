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

    [Fact]
    public void NickName_MustBeNull()
    {
        var names = new Names();
        names.NickName = "Strong man";
        Assert.NotNull(names.NickName);
    }

    [Fact]
    public void MakeFullName_AlwaysReturnsValue()
    {
        var names = new Names();
        var result = names.MakeFullName("Aref", "Karimi");
        Assert.NotNull(result);
        Assert.True(!string.IsNullOrEmpty(result));
    }
}