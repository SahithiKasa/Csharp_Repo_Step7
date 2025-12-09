using System;

public delegate int AccountCreation();
public delegate void AccountNotification();
public delegate double BalanceCheck();
public class Bank
{
    public static int CreateAccount()
    {
        Console.WriteLine("Account is created successfully.");
        return 1001;  // returning new account number
    }

    public static void NotifyCustomer()
    {
        Console.WriteLine("Notification sent to customer.");
    }

    public static double GetBalance()
    {
        Console.WriteLine("Fetching balance...");
        return 25000.75;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Delegate 1 → returns int
        AccountCreation create = Bank.CreateAccount;
        int accNum = create();
        Console.WriteLine("Account Number: " + accNum);

        // Delegate 2 → void
        AccountNotification notify = Bank.NotifyCustomer;
        notify();

        // Delegate 3 → returns double
        BalanceCheck balance = Bank.GetBalance;
        double amt = balance();
        Console.WriteLine("Balance: " + amt);
    }
}