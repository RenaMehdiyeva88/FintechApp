using FintechApp;

class Program
{
    static E_Kassa eKassa = new E_Kassa();

    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            ShowMainMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateE_Kassa();
                    break;
                case "2":
                    CreateAccount();
                    break;
                case "3":
                    ShowAllAccounts();
                    break;
                case "4":
                    ShowAccountDetails();
                    break;
                case "5":
                    ChangeAccountStatus();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ShowMainMenu()
    {
        Console.WriteLine("1. Create E-Kassa");
        Console.WriteLine("2. Create an account linked to the E-Kassa");
        Console.WriteLine("3. Show all accounts linked to the E-Kassa");
        Console.WriteLine("4. View account by account number");
        Console.WriteLine("5. Change account status");
        Console.WriteLine("6. Exit");
        Console.Write("Make your selection: ");
    }

    static void CreateE_Kassa()
    {
        Console.WriteLine("E-Kassa created.");
    }

    static void CreateAccount()
    {
        Console.Write("Enter the account currency (AZN/USD): ");
        string currency = Console.ReadLine();
        Console.Write("Enter the opening balance: ");
        double balance = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the account description: ");
        string description = Console.ReadLine();

        eKassa.CreateAccount(currency, balance, description);
    }

    static void ShowAllAccounts()
    {
        eKassa.ShowAllAccounts();
    }

    static void ShowAccountDetails()
    {
        Console.Write("Enter the account number: ");
        string accountNumber = Console.ReadLine();
        var account = eKassa.GetAccountByNumber(accountNumber);

        if (account != null)
        {
            account.ShowAccountDetails();
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    static void ChangeAccountStatus()
    {
        Console.Write("Enter the account number: ");
        string accountNumber = Console.ReadLine();
        Console.Write("Enter the new status (Active/Deactive): ");
        string newStatus = Console.ReadLine();

        eKassa.ChangeAccountStatus(accountNumber, newStatus);
    }
}
