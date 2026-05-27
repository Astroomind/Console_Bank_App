public class BankAccount
{
    public string AccountHolderName { get; set; }
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public BankAccount (string AccountHolderName)
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
            Console.WriteLine("Deposit successful");
            Console.WriteLine($"Your Balance is {Balance}");cd 
        }
    }
}