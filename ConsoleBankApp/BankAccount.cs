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
     
    public static Deposit()
    {

    }
}