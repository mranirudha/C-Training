using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomTraining.Basics
{
    public class Basic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!....This is from my Code");

            byte bytevar;

            bytevar = 5;

            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);


            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);

            int var = 345678888;

            Console.WriteLine("Integer Value"+ var);

            Console.WriteLine(long.MaxValue);

            long longvar = 64564579087920735L;

            Console.WriteLine(longvar + " LongValue");

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);


            float fvar = 245.67f;

            var = (int)fvar;
            Console.WriteLine(var);

            char abc = 'A';

            bool status = true;

            string str;

            str = "My name is Anirudha      ";

            Console.WriteLine(str.Length);

            Console.WriteLine(str.Trim());

            Console.WriteLine(str.ToUpper());

            Console.WriteLine(str.Contains("Ani"));

            Console.WriteLine(str.StartsWith("A"));

            //string Interpollation

            Console.WriteLine("Vlaue of the String "+str+" and Print it");

            Console.WriteLine($"Vlaue of the String {str} and Print it and the status is {status}");


        }

    }
}
