using CsharpQuests;

namespace CsharpQuestsTest;

public partial class SavingsAccountTests
{
    [Fact]
    public void Interest_rate_positive_less_than_1000_dollars()
    {
        float result = SavingsAccount.InterestRate(200.75m);
        Assert.Equal(result, 0.5);
    }

    [Fact]
    public void Interest_rate_negative_balance()
    {
        float result = SavingsAccount.InterestRate(-1m);

        Assert.Equal(result, 3.213f);
    }

    [Fact]
    public void Interest_rate_equal_to_1000_lass_than_5000()
    {
        float result = SavingsAccount.InterestRate(4000m);
        Assert.Equal(result, 1.621f);
    }

    [Fact]
    public void Interest_rate_more_than_5000()
    {
        float result = SavingsAccount.InterestRate(6000m);
        Assert.Equal(result, 2.475f);
    }

    [Fact]
    public void Interest_on_negative_balance()
    {
        decimal result = SavingsAccount.Interest(-10000m);
        Assert.Equal(result, -321.3m);
    }

    [Fact]
    public void Interest_on_small_balance()
    {
        decimal result = SavingsAccount.Interest(555.55m);
        Assert.Equal(result, 2.77775m);
    }

    [Fact]
    public void Interest_on_medium_balance()
    {
        decimal result = SavingsAccount.Interest(4999.99m);
        Assert.Equal(result, 81.0498379m);
    }

    [Fact]
    public void Interest_on_large_balance()
    {
        decimal result = SavingsAccount.Interest(34600.80m);
        Assert.Equal(result, 856.36980m);
    }

    [Fact]
    public void Annual_balance_small_positive() 
    {
        decimal result = SavingsAccount.AnnualBalanceUpdate(200.75m);
        Assert.Equal(result, 201.75375m);
    }

    [Fact]
    public void Annual_balance_small_negative() 
    {
        decimal result = SavingsAccount.AnnualBalanceUpdate(-400.75m);
        Assert.Equal(result, -413.6260975m);
    }

    [Fact]
    public void Annual_balance_big_positive() 
    {
        decimal result = SavingsAccount.AnnualBalanceUpdate(40789789798780.75m);
        Assert.Equal(result, 41799337096300.5735625m);
    }

    [Fact]
    public void Annual_balance_big_negative() 
    {
        decimal result = SavingsAccount.AnnualBalanceUpdate(-239492349923429834.75m);
        Assert.Equal(result, -247187239126469635.3405175m);
    }

    [Fact]
    public void Years_to_get_desired_balance()
    {
        int result = SavingsAccount.YearsBeforeDesiredBalance(200.74m, 214.88m);
        Assert.Equal(result, 14);
    }
}