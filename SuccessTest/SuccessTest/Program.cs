using System;
using System.Collections.Generic;
using System.Diagnostics;

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
            // compareMethods();
        }

        static void compareMethods()
        {
            Stopwatch watch = new Stopwatch();
            int start = 500000, finish = 1000000;
            IPrimaryCheckingStrategy divisionStrat = new DivisionStrategy(),
                eratosthenesStrat = new EratosthenesSieveStrategy(finish);

            PrimaryNumberChecker checker = new PrimaryNumberChecker(divisionStrat);
            checkDuration(checker, watch, divisionStrat.GetType().ToString(), start, finish);
            checker.setStrategy(eratosthenesStrat);
            checkDuration(checker, watch, eratosthenesStrat.GetType().ToString(), start, finish);
        }

        static void checkDuration(PrimaryNumberChecker checker, Stopwatch watch, string strategy, int start, int finish)
        {
            watch.Restart(); watch.Start();
            checker.getPrimaryNumbers(start, finish);
            watch.Stop();
            Console.WriteLine($"Finding all primes within [{start}, {finish}] using {strategy} took {watch.Elapsed.ToString()}");
        }
    }
}
