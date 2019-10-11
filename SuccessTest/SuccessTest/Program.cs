using System;

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

            PrimaryNumberChecker checker = new PrimaryNumberChecker();

            Console.WriteLine($"Primary numbers in the range: [{1}, {2}]", start, finish);
            for (int i = start; i <= finish; i++)
            {
                if (checker.isPrimary(i)) Console.WriteLine(i);    
            }
        }
    }
}
