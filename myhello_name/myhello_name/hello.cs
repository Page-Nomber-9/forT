using System;

namespace myhello
{
    class hello
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            string a = Convert.ToString(args[0]);
            if (a == "myhello")
            {
                string b = Convert.ToString(args[1]);
                Console.WriteLine($"привет, {b}");
            }
            else
            {
               Console.WriteLine("твоё имя... НАЗАВИ МНЕ СВОЁ ИМЯ!");
                    string b = Convert.ToString(args[1]);
                    Console.WriteLine($"привет, {b}");
               
            }
            Console.ReadKey();
        }
    }
}
