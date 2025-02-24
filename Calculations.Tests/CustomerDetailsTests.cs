using Xunit;

namespace Calculations.Tests;

[Collection("Customer")]
public class CustomerDetailsTests(CustomerFixture customerFixture)
{
    private readonly CustomerFixture _customerFixture = customerFixture;

    [Fact]
    public void GetFullName_GivenFirstAndLastName_ReturnsFullName()
    {
        var customer = _customerFixture.Cust;
        Assert.Equal("Aref Karimi", customer.GetFullName("Aref", "Karimi"));
    }
}