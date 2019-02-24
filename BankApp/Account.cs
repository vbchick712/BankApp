using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{

    enum TypeOfAccount
    {
        Checking,
        Savings,
        CD
    }


    class Account
    {
        private static int lastAccountNumber = 0;
       
        #region Properties
        /// <summary>
        /// Account number for the user
        /// Public/private data type name {get; set;}
        /// </summary>
        public int AccountNumber { get; }

        public string AccountName { get; set; }

        public decimal Balance { get; private set; }

        public DateTime CreateDate { get; }

        public string EmailAddress { get; set; }

        public TypeOfAccount AccountType { get; set; }
        #endregion

        #region Constructors

        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreateDate = DateTime.UtcNow;
        }


        #endregion

        #region Methods

        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">Amount to be deposited</param>

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdrawal(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
            
}
