using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var myAccount = Bank.CreateAccount("My Checking", "test@test.com", initialDeposit = 1000);
            Console.WriteLine($"AN: {myAccount.AccountNumber}, Balance: {myAccount.Balance:C}, AT: {myAccount.AccountType}, CD: {myAccount.CreateDate}");

            var myAccount2 = Bank.CreateAccount("My Savings", "test@test.com", TypeOfAccount.Savings);
            myAccount2.Deposit(2000);
            Console.WriteLine($"AN: {myAccount2.AccountNumber}, Balance: {myAccount2.Balance:C}, AT: {myAccount2.AccountType}, CD: {myAccount2.CreateDate}");
        }
    }
}
