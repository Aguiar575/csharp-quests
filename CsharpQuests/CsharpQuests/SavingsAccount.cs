namespace CsharpQuestsTest;

public class SavingsAccount
{
    // READ THIS
    // C# has three floating-point types:
    // float: 4 bytes (~6-9 digits precision). Written as 2.45f.
    // double: 8 bytes (~15-17 digits precision). This is the most common type. Written as 2.45 or 2.45d.
    // decimal: 16 bytes (28-29 digits precision). Normally used when working with monetary data, 
    // as its precision leads to less rounding errors. Written as 2.45m.
    public static float InterestRate(decimal balance) =>
     balance switch
     {
         < 0m => 3.213f,
         < 1000m => 0.5f,
         < 5000m => 1.621f,
         _ => 2.475f,
     };

    public static decimal Interest(decimal balance) =>
        (balance * (decimal)InterestRate(balance)) / 100;

    public static decimal AnnualBalanceUpdate(decimal balance) =>
        balance += Interest(balance);

    public static int YearsBeforeDesiredBalance(
        decimal actualBalance,
        decimal desiredBalance)
    {
        int yearsToDesiredBalance = 0;
        while (desiredBalance > actualBalance)
        {
            actualBalance = AnnualBalanceUpdate(actualBalance);
            yearsToDesiredBalance++;
        }

        return yearsToDesiredBalance;
    }
}