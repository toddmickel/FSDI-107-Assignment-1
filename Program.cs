using System;

namespace intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.Exc1();
            float res = p.Sum(2.7f, 5.4f);
            Console.WriteLine(res);

            string ans = p.GetTheAnswer();
            Console.WriteLine("The answer to life, the universe, and everything is: " + ans);

            // get the most expensive of 3 product prices
            decimal exp = p.GetMostExpensive(23453.45m, 3462.36m, 6546.02m);
            Console.WriteLine("The most expensive item costs " + exp);

        }

        decimal GetMostExpensive(decimal n1, decimal n2, decimal n3) => Math.Max(Math.Max(n1, n2), n3);

        string GetTheAnswer()
        {
            return "42";
        }

        float Sum(float n1, float n2)
        {
            return n1 + n2;
        }

        void Exc1()
        {
            // print numbers from 1 to 14
            // except 7 and 13
            for (int i = 1; i <= 14; i++)
            {
                if (i != 7 && i != 13)
                {
                    Console.WriteLine(i);
                }
            }
        }

        void TestVariables()
        {
            // variable declaration: data_type name
            string name = "Todd Mickel";
            int age = 43;
            decimal total = 103.50m; // for money -- must follow with an m for decimal when hard coding value
            float average = 253.552f; // for mathematical calculations -- must follow with an f for float when hard coding value
            bool found = false;


        }

        // function syntax: return_type name (params)
        string SayHello()
        {
            Console.WriteLine("Hello there!");
            int age = 17;

            if (age > 18)
            {
                return "Hi!";
            }

            return "";

        }

    }
}
