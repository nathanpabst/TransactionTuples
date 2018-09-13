using System;
using System.Collections.Generic;

namespace TransactionTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("CL-107", 19.99, 500));
            transactions.Add(("CL-108", 29.99, 300));
            transactions.Add(("CL-109", 39.99, 275));
            transactions.Add(("CL-110", 49.99, 250));
            transactions.Add(("L-220", 1.99, 7000));

            int sales = 0;
            double revenue = 0;

            foreach ((string product, double amount, int quantity) in transactions)
            {
                sales += quantity;
                revenue += amount * quantity;
            }

            Console.ReadLine();

        }
    }
}
