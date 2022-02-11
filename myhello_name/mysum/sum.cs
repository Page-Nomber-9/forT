using System;

namespace mysum
{
    class sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            double a = Convert.ToDouble(args[0]);
            double b = Convert.ToDouble(args[1]);
            Console.WriteLine(a+b);
            Console.ReadKey();
        }
    }
}
