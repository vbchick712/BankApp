using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("Welcome to the Bank!");

            while (true)
            {
                Console.WriteLine("O. Exit");
                Console.WriteLine("1. Create an Account");
                Console.WriteLine("2. Make a Deposit");
                Console.WriteLine("3. Make a Withdrawal");
                Console.WriteLine("4. Print All Accounts");
                Console.WriteLine("5. Print All Transactions");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the bank.");
                        return;

                    case "1":
                        Console.Write("Account Name: ");
                        var accountName = Console.ReadLine();
                        Console.Write("Email Address :");
                        var emailAddress = Console.ReadLine();
                        var myAccount = Bank.CreateAccount(accountName, emailAddress);
                        Console.WriteLine($"Acount Name: {myAccount.AccountName}, Email Address: {myAccount.EmailAddress}, Account Number: {myAccount.AccountNumber");
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
