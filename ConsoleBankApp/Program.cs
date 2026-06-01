
Console.WriteLine("Hello! Welcome to your Banking App");
Console.WriteLine("What is your name?");

string Name = Console.ReadLine(); //Asking user for their name and creating an instance of BankAccount so that we can use it later on.
BankAccount Account = new BankAccount(Name);

Console.WriteLine($"Thank you {Name}.");
Console.WriteLine($"Your account number is: {Account.AccountNumber}.");

bool Running = true;

while (Running == true)
{
    Console.WriteLine("Please choose from the following options:");
    Console.WriteLine("1 - Deposit");
    Console.WriteLine("2 - Withdraw");
    Console.WriteLine("3 - View Balance");
    Console.WriteLine("4 - Transaction History");
    Console.WriteLine("5 - Exit");
    string Choice = Console.ReadLine();
    switch (Choice)
    {
        case "1":
            Console.WriteLine("Enter amount to deposit:");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            Account.Deposit(depositAmount);
            break;
        case "2":
            Console.WriteLine("Enter amount to withdraw:");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            Account.Withdraw(withdrawAmount);
            break;
        case "3":
            Console.WriteLine($"Your Balance is: {Account.Balance}");
            break;
        case "4":
            Console.WriteLine("Here is your transaction history:");
            Account.PrintTransactionHistory();
            break;
        case "5":
            Console.WriteLine("Goodbye!");
            Running = false;
            break;
        default:
            Console.WriteLine("Invalid Option. Please choose from 1-4");
            break;
    };
}
