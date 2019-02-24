﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    static class Bank
    {
        public static Account CreateAccount(string accountName, string emailAddress, TypeOfAccount accountType, decimal initialDeposit = 0)
        {
            var account = new Account
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                AccountType = accountType,
            };
            if (initialDeposit > 0)
            {
                account.Deposit(initialDeposit);
            }

            return account;
        }
    }
}
