using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.BankApplication
{
    public class DemoBankAccount
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Anirudha", 2000);

            Console.WriteLine($"Account - {account.Number} was created for {account.Owner} with Initial Balance as {account.Balance}");

            account.MakeDeposit(1000, DateTime.Now, "Got my salary");

            account.MakeWithdrawal(400, DateTime.Now, "Shopping");

            Console.WriteLine($"Current Balance - {account.Balance}");

            Console.WriteLine(account.GetTransactionStatement());

            var atulyaaAccount = new BankAccount("Atulyaa", 2000);

            Console.WriteLine($"Account - {atulyaaAccount.Number} was created for {atulyaaAccount.Owner} with Initial Balance as {atulyaaAccount.Balance}");
        }
    }
}
