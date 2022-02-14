using System;

namespace Chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 1;
            Console.WriteLine(args.Length);
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            while (a/10>0)
            {
                a = a / 10;
                x++;
            }
            while (b / 10 > 0)
            {
                b = b / 10;
                y++;
            }
            Console.WriteLine($"в 1-м числе {x} цифр. В 2-м числе {y} цифр");
        }
    }
}
