using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
    class AccountCalculation
    {
        static void Main(string[] args)
        {
            BankAccountDetails bankAccountDetails= new BankAccountDetails();

            bankAccountDetails.AccountHolderName = "Anirudha Sahoo";
            bankAccountDetails.AccountNumber = 1234567890;
            bankAccountDetails.InitialAccountBalance = 15000;
            Console.WriteLine($"Account Holder Name is {bankAccountDetails.AccountHolderName}");
            Console.WriteLine($"Account Number is {bankAccountDetails.AccountNumber}");
            bankAccountDetails.DepositAmount(5000);
            bankAccountDetails.WithdrawalAmount(2000);
            bankAccountDetails.DisplayCurrentBalance();


        }
    }
}
