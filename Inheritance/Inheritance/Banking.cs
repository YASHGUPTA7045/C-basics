namespace Inheritance;


class Banking
{
    private long AccountNumber;
    private long balance;

    public void Deposit(long amount)
    {
        if (0 > amount)
        {
            Console.WriteLine("invalid Number");
        }
        else
        {
            Console.WriteLine($"deposited:{amount}");
        }

    }
    public void withdraw(long amount)
    {
        if (balance > amount)
        {
            balance -= amount;
            Console.WriteLine($"the withdra amount is {amount} ");
        }
        else
        {
            Console.WriteLine($"deposited:{amount}");
        }

    }
    public long GetAccountNumber()
    {
        return AccountNumber;
    }
    public long GetBalance()
    {
        return balance;
    }


}
