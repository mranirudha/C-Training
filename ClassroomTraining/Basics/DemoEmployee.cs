using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
   public class DemoEmployee
    {
        static void Main(string[] args)
        {
            Employee Anirudha;

            Anirudha = new Employee();

            Anirudha.Salary = 20000;
            Anirudha.Bonus = 5000;


           

            Anirudha.GetSalary();

            Anirudha.CalculateSalary();

            Employee RAM = new Employee();

            RAM.Salary = 2000;
            RAM.Bonus = 4000;

            int RAMSalary = RAM.CalculateSalary1();

            Console.WriteLine($"RAM Salary is {RAMSalary}");


            Employee TUL = new Employee();

            TUL.Salary = 2300;
            TUL.Bonus = 4500;

            int TULSalary = TUL.CalculateSalary2(5000,2000);

            Console.WriteLine($"TUL Salary is {TULSalary}");

            Employee RAKESH = new Employee();

            RAKESH.Salary = 2300;
            RAKESH.Bonus = 4500;

            int RAKESHSalary = RAKESH.CalculateSalary3(5000, 2000);

            Console.WriteLine($"RAKESH Salary is {RAKESHSalary}");






        }

    }
}
