using System;

namespace ЛР_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* найти разность между максимальным и минимальным элементами массива.
             * поменять местами макс и мин массива
             * отсортировать массив*/
            Console.WriteLine("Введите количество элементов массива");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] ar = new int [n];
            Console.WriteLine("Введите сами элементы массива");
            for (int i= 0; i < n; i++)
            {
                ar[i] = Convert.ToInt16(Console.ReadLine());
            }
            int Max = ar[0];
            int Min = Max;
            int IMin = 0, IMax = 0;
            for (int i = 0; i < n; i++)
            {
                //Нашём максимальный элемент и его индекс
                if (ar[i] > Max)
                {
                    IMax = i;
                    Max = ar[i];
                }
                //Нашёл минимальный элемент и его индекс
                if (ar[i] < Min)
                {
                    IMin = i;
                    Min = ar[i];
                }
            }
            Console.WriteLine($"Максимальный элемент: {Max}/ Минимальный элемент массива: {Min}\nИх разность равна: {Max-Min}");
            //Поменял их местами
            ar[IMax] = Min; ar[IMin] = Max;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ar[i]} ");
            }
            //Сортируем, сортируем!
            Array.Sort(ar);
            Console.WriteLine("\n*********");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{ar[i]} ");
            }
            Console.ReadKey();
        }
    }
}
