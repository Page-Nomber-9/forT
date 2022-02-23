using System;
using System.Collections.Generic;

namespace Apteka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");
            Console.WriteLine("введите команыды (если вы не знаете команд, то введите 'help'");
            bool forever = true;
            //хоть тут и forever, программа не бесконечна
            while (forever == true)
            {
                string comand = Console.ReadLine();
                if (comand=="end")
                {
                    forever = false;
                }
                if (comand=="inf")
                {
                    Ap sh = new Ap();
                    sh.Showinf();
                    sh.Maxcost();
                    sh.Allcost();
                }
                if (comand == "max")
                {
                    Ap sh = new Ap();
                    sh.Maxcost();
                }
                if (comand == "all")
                {
                    Ap sh = new Ap();
                    sh.Allcost();
                }
                if (comand == "help")
                {
                    Console.WriteLine("end - позволяет завершить работу программы");
                    Console.WriteLine("all - выводит общую стоимость припаратов");
                    Console.WriteLine("max - выводит название и стоимость самого дорогого припарата");
                    Console.WriteLine("inf - выводит всю информацию");
                    Console.WriteLine("help - выводит список команд и их функции");
                }
            }
        }
    }
}
