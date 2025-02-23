namespace Calculations;

public class Customer
{
    public virtual int OrdersByName(string name) {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("Name not be null");

        return 100;
    }
    
    public int Age => 35;
}

public class LoyalCustomer: Customer
{
    public int Discount { get; set; }
    public LoyalCustomer()
    {
        Discount = 10;
    }
    public override int OrdersByName(string name){
        return 101;
    }
}

public static class CustomerFactory {
    public static Customer CreateCustomerInstance(int orderCount){
        if (orderCount <= 100)
        {
            return new Customer();
        }
        return new LoyalCustomer();
    }
}