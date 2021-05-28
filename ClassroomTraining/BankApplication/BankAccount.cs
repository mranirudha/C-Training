using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.BankApplication
{
    public class BankAccount
    {
        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;

            Number = $"{accountNumberSeed}";

            accountNumberSeed++;

            MakeDeposit(initialBalance, DateTime.Now, "Initial Deposit");

        }
        public string Owner { get; set; }

        public string Number { get; }

        public decimal Balance
        {

            get
            {
                decimal balance = 0;

                foreach (var transaction in allTransactions)
                {
                    balance = balance + transaction.Amount;
                }

                return balance;
            }

        }

        private static long accountNumberSeed = 9130000000;

        List<Transaction> allTransactions = new List<Transaction>();

        public string GetTransactionStatement()
        {
            StringBuilder inReader = new StringBuilder();

            decimal balance = 0;

            foreach (var transaction in allTransactions)
            {
                balance = balance + transaction.Amount;
                inReader.AppendLine($"Date : {transaction.DateOfTransaction} a transaction of amount : {transaction.Amount} was done with comment {transaction.Comments} and the current balance is {balance}");
            }

            return inReader.ToString();
        }

        public void MakeDeposit(decimal amount, DateTime date, string comments)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be above zero");
            }

            var deposit = new Transaction(amount, date, comments);

            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string comments)
        {

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be above zero");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient Balance");
            }

            var withdraw = new Transaction(-amount, date, comments);

            allTransactions.Add(withdraw);

        }

    }
}
