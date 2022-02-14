using System;

namespace ArMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b=1, c=1, i=0;
            bool f = false;
            for (int n = 0; f==false; n++)
            {
                a = Convert.ToInt32(
                if (a>=b)
                {
                    i = n;
                    c = b;
                    b = a;
                }
            }
            Console.WriteLine($"{c}[{i}");
        }
    }
}
