

namespace methods.models;

class Account
{
    public string Name { get; set; }
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    public Account(string name, string accountNumber, double balance)
    {
        Name = name;
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Account: {AccountNumber}, Balance: {Balance}");
    }
}

class Bank
{
    private List<Account> accounts = new List<Account>();


    public void AddAccount(Account acc)
    {
        accounts.Add(acc);
    }


    public void RemoveAccount(string accountNumber)
    {
        accounts.RemoveAll(a => a.AccountNumber == accountNumber);
    }

    public void Deposit(string accountNumber, double amount)
    {
        Account acc = accounts.Find(a => a.AccountNumber == accountNumber);
        if (acc != null)
        {
            acc.Balance += amount;
        }
    }

    public void Withdraw(string accountNumber, double amount)
    {
        Account acc = accounts.Find(a => a.AccountNumber == accountNumber);
        if (acc != null && acc.Balance >= amount)
        {
            acc.Balance -= amount;
        }
    }

    public void ShowAccounts()
    {
        foreach (var acc in accounts)
        {
            acc.PrintInfo();
        }
    }
}
