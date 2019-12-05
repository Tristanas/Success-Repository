using System;
using System.Collections.Generic;

namespace SuccessTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Error, insufficient arguments");
                return;
            }

            int start = int.Parse(args[0]),
                finish = int.Parse(args[1]);

            if (start > finish)
            {
                Console.WriteLine("Error, interval start is higher than end.");
                return;
            }

            PrimaryNumberChecker checker = new PrimaryNumberChecker(new EratosthenesSieveStrategy(finish));

            Console.WriteLine($"Primary numbers in the range: [{start}, {finish}]");
            IList<int> primaryNumbers = checker.getPrimaryNumbers(start, finish);
            foreach(int number in primaryNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
