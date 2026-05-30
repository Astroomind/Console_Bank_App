public class BankAccount
{
    public string AccountHolderName { get; set; }
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public List<Transaction> Transactions { get; set; } = new List<Transaction>();

    public BankAccount(string AccountHolderName)
    {
        Random rand = new Random();
        AccountNumber = $"ACC{rand.Next(10000, 99999)}"; // Example output: 1386420123
        this.AccountHolderName = AccountHolderName;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Please Deposit more than £0");
        }
        else
        {

            Balance += amount;
            Transactions.Add(new Transaction { Type = "Deposit", Amount = amount, Date = DateTime.Now, BalanceAfter = Balance });
            Console.WriteLine("Deposit successful");
            Console.WriteLine($"Your Balance is {Balance}");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Please withdraw a positive number");
        }
        else if (amount > Balance)
        {
            Console.WriteLine("Unable to withdraw, insufficient funds");
        }
        else
        {
            Balance -= amount;
            Transactions.Add(new Transaction { Type = "Withdraw", Amount = amount, Date = DateTime.Now, BalanceAfter = Balance });
            Console.WriteLine($"Withdraw Successful, Your current balance is: {Balance}");
        }
    }
    public void PrintTransactionHistory()
    {
        if (Transactions.Count == 0)
        {
            Console.WriteLine("No Transactions yet");
            return;
        }
        foreach (Transaction Trans in Transactions)
        {
            Console.WriteLine($"Type: {Trans.Type}");
            Console.WriteLine($"Amount: {Trans.Amount}");
            Console.WriteLine($"Date: {Trans.Date}");
            Console.WriteLine($"Balance After: {Trans.BalanceAfter}");
        }
    }

    
}