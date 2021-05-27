using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
    class AccountCalculation
    {
        static void Main(string[] args)
        {
            BankAccountDetails bankAccountDetails = new BankAccountDetails();

            bankAccountDetails.AccountHolderName = "Anirudha Sahoo";
            bankAccountDetails.AccountNumber = 1234567890;
            bankAccountDetails.InitialAccountBalance = 15000;
            Console.WriteLine($"Account Holder Name is : {bankAccountDetails.AccountHolderName}");
            Console.WriteLine($"Account Number is : {bankAccountDetails.AccountNumber}");
            //bankAccountDetails.DepositAmount(5000);
            //bankAccountDetails.WithdrawalAmount(2000);
            //bankAccountDetails.DisplayCurrentBalance();
            while (true)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("Press \'a\' for Diplaying Balance");
                Console.WriteLine("Press \'b\' for Balace Deposit");
                Console.WriteLine("Press \'c\' for Balace Withdrawl");
                Console.WriteLine("Press \'d\' for Statement");
                Console.WriteLine("Press \'e\' To Exit");

                char ch = Console.ReadLine()[0];
                if (ch == 'e')
                {
                    break;
                };
                switch (ch)
                {
                    case 'a':
                        bankAccountDetails.DisplayCurrentBalance();
                        break;
                    case 'b':
                        Console.WriteLine("Enter the Deposit Amount\n");
                        long credit = Convert.ToInt64(Console.ReadLine());
                        bankAccountDetails.DepositAmount(de);
                        break;

                    case 'c':
                        Console.WriteLine("Enter the Withdrawl Amount\n");
                        long debit = Convert.ToInt64(Console.ReadLine());
                        bankAccountDetails.WithdrawalAmount(debit);
                        break;

                    case 'd':
                        bankAccountDetails.GenerateStatement();
                        break;

                    default:
                        Console.WriteLine("Invalid Choice\n");
                        break;
                }
            }
        }
    }
}
