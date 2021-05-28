using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
    class ChildClass : ParentClass
    {
        public void IntrestClaulation(int year)
        {
            Console.WriteLine($"Intrest Earned = {accountBalance * 0.01 * year}");
        }

        static void Main(string[] args)
        {

            ChildClass cs = new ChildClass();
            ParentClass ps = new ParentClass();


            cs.accountBalance = 2000;
            ps.accountBalance = 2000;

            ps.IntrestClaulation();
            cs.IntrestClaulation(4);


        }



    }
}
