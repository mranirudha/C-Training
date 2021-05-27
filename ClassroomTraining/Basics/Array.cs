using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
    class Array
    {

        static void Main(string[] args)
        {

            int[] arr = new int[10];

            int ones = 0;
            int zeros = 0;

            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 0;
            arr[3] = 1;
            arr[4] = 0;
            arr[5] = 1;
            arr[6] = 0;
            arr[7] = 1;
            arr[8] = 0;
            arr[9] = 1;

            foreach(int i in arr) 
            {
                if (i == 1) 
                {
                    ones += 1;

                }
                if (i == 0)
                {
                    zeros += 1;

                }
            }
            Console.WriteLine($"Count of ones -->{ones} and Count of Zeros {zeros}");

        }
    }
}
