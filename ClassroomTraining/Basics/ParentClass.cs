using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
    class ParentClass



    {

        public string accountHolderName;
        public long accountNumber;
        public long initialAccountBalance;
        public long accountBalance;
        public void IntrestClaulation()
        {
            Console.WriteLine($"Intrest Earned = {accountBalance*0.01}");
         
        }


    }
}
