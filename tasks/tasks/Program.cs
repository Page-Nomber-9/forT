using System;
using System.Collections.Generic;
namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool forever = true;
            Console.WriteLine("делай что хочешь! если не знаешь как - введи help");
            while (forever==true)
            {
                string a = Console.ReadLine();
                if (a=="end")
                {
                    forever = false;
                }
                if (a == "help")
                {
                    Console.WriteLine("stop - останавливает машину определённой марки");
                    Console.WriteLine("start - заводит машину определённой марки");
                    Console.WriteLine("end - завершить программу");
                    Console.WriteLine("help - выводит команды и их функции");
                }
                if (a == "start")
                {
                    string x = Console.ReadLine();
                    Mashina M = new Mashina();
                    M.Start(x);
                }
                if (a == "stop")
                {
                    string x = Console.ReadLine();
                    Mashina M = new Mashina();
                    M.Stop(x);
                }
            }
        }
    }
}
