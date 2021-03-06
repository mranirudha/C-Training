using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
    class BankAccountDetails
    {
        private string accountHolderName;
        private long accountNumber;
        private long initialAccountBalance;
        private long accountBalance;

        private List<string> statement = new List<string>();



        public string AccountHolderName
        {
            get
            { 
                return this.accountHolderName; 
            } 
            set
            { 
                this.accountHolderName = value;
            }
        }

        public long AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
            set
            {
                if ((value > 10000000000) || (value < 999999999))
                {
                    throw new ArgumentOutOfRangeException("Not A Valid Account Number");
                }
                else
                {
                    this.accountNumber = value;

                }
            }
        }

        public long InitialAccountBalance
        {
            get
            { 
                return this.accountBalance;
            }
            set
            { 
                if (value > 0)
                {
                    this.accountBalance = value;
                }
                else
                { 
                    throw new ArgumentOutOfRangeException("Invalid Balance");
                }
            }
        }

        public void DisplayCurrentBalance()
        {
            Console.WriteLine($"Current Balance is {this.accountBalance}");
        }

        public void DepositAmount(long depositAmount)
        {
            if (depositAmount > 0)
            {
                this.accountBalance += depositAmount;
                Console.WriteLine("Amount Deposited successfully...");
                statement.Add($"{DateTime.Now} : Credit of Rs {depositAmount}");
            }
            else
            {
                Console.WriteLine("Invalid Deposit Amount");
            }
        }

        public void WithdrawalAmount(long withdrwAmount)
        {
            if ((this.accountBalance >= withdrwAmount) && (withdrwAmount > 0))
            {
                this.accountBalance -= withdrwAmount;
                Console.WriteLine("Amount Withdrwal successfully");
                statement.Add($"{DateTime.Now} : Debit of Rs {withdrwAmount}");
            }
            else
            {
                Console.WriteLine("Invalid Withdrwal Amount");
            }
        }

        public void GenerateStatement()
        {
            Console.WriteLine("\n-----------------Statement-Starts Here-----------------------------\n");
            Console.WriteLine($"Account Holder Name is:  {AccountHolderName} \nAccount Number is:  {AccountNumber}");
            Console.WriteLine($"----------------------------------------------------------------------");
            foreach (string str in statement) { Console.WriteLine($"{str}\n"); }
            DisplayCurrentBalance();
            Console.WriteLine("\n-----------------Statement-Ends Here-----------------------------\n");

        }


    }
}
