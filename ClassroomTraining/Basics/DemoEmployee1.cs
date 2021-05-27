using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
    public class DemoEmployee1
    {
        static void Main(string[] args)
        {
            Employee Vishal = new Employee(3000,2000);

            Vishal.Salary = 10000;
            Vishal.Bonus = 4000;


            Vishal.CalculateSalary();
        }
    }
}
