using Xunit;
using Calculations;

namespace Calculations.Tests;

public class CustomerTests
{
    // [Fact]
    // public void Name_NotEmpty()
    // {
    //     var customer = new Customer();
    //     Assert.NotEmpty(customer.Name);
    //     Assert.False(string.IsNullOrEmpty(customer.Name));
    // }

    [Fact]
    public void Age_DiscountRange()
    {
        var customer = new Customer();
        Assert.InRange(customer.Age, 25, 40);
    }

    [Fact]
    public void OrdersByName_NameNotNull()
    {
        var customer = new Customer();
        Assert.Throws<ArgumentException>(() => {customer.OrdersByName(""); });
        var ex = Assert.Throws<ArgumentException>(() => {customer.OrdersByName(null!); });
        Assert.Equal("Name not be null", ex.Message);
    }

    [Fact]
    public void LoyalCustomer_OrdersGreater100()
    {
        var customer = CustomerFactory.CreateCustomerInstance(101);
        var loyalCustomer = Assert.IsType<LoyalCustomer>(customer);
        Assert.Equal(10, loyalCustomer.Discount);
    }

}