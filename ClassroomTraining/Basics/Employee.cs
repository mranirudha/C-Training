using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
    class Employee
    {
      private  int salary;
      private int bonus;

        public Employee()
        {
            salary = 35000;
            bonus = 15000;
        }


        public Employee(int salary, int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }

        public int Salary { get
            {
                return salary;

            }
              set
            {
                if (value>=0)
                {
                    this.salary = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Salary Cann't be negative");

                }
            }
                
                }


        public int Bonus
        {
            get
            {
                return bonus;

            }
            set
            {
                if (value >= 0)
                {
                    this.bonus = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Bonus Cann't be negative");

                }
            }

        }

        /*Comment---------to test github--------------*/
        /*Comment---------to test gitfetch--------------*/
        

        public void SetSlary(int salary)
        {
            if (salary >= 0)
            {
                this.salary = salary;
            }
            throw new ArgumentOutOfRangeException("Salary Cann't be negative");
        }


        public int GetSalary()
        {
            return salary;
        }


        public void SetBonus(int bonus)
        {
            this.bonus = bonus;
        }


        public void CalculateSalary() 
        {
            int totalsalary;

            totalsalary = salary + bonus;

            Console.WriteLine($"Total Salary {totalsalary}");
        
        }

        public int CalculateSalary1()
        {
            int totalsalary;

            totalsalary = salary + bonus;

            return totalsalary;

        }

        public int CalculateSalary2(int salary, int bonus)
        {
            int totalsalary;

            totalsalary = salary + bonus;

            return totalsalary;

        }

        public int CalculateSalary3(int salary, int bonus)
        {
            int totalsalary;

            totalsalary = this.salary + this.bonus;

            return totalsalary;

        }






    }
}
