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
            void ArMax(in int [] AAA, in int K, out int Mx, out int Mn, out int MxI, out int MnI)
            {
                Mx = AAA[0];
                Mn = AAA[0];
                MxI = 0;
                MnI = 0;
                for (int i=0; i<K; i++)
                {
                    if (AAA[i] > Mx)
                    {
                        MxI = i;
                        Mx = AAA[i];
                    }
                    //Нашёл минимальный элемент и его индекс
                    if (AAA[i] < Mn)
                    {
                        MnI = i;
                        Mn = AAA[i];
                    }
                }
            }
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
            ArMax(ar, n, out Max, out Min, out IMax, out IMin);
            Console.WriteLine($"максимальный элемент массива: {Max} с индексом {IMax}.\nМинимальный элемент массива: {Min} с индексом {IMin}");
            Console.WriteLine("Я всё перемешал и теперь массив выглядит так:");
            ar[IMin] = Max;
            ar[IMax] = Min;
            bool P = true;
            //для возможности подмены элементов в массиве
            int copy = 0;
            //Пузырьковая сортировка: концепция 2
            for (int i=0; i<n-1; i++)
            {
                if (P==false)
                {
                    P = true;
                    i = 0;
                }
                if (ar[i] > ar[i + 1])
                {
                    P = false;
                    copy = ar[i];
                    ar[i] = ar[i + 1];
                    ar[i + 1] = copy;
                    i = 0;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ar[i]);
            }
            Console.ReadKey();
        }
    }
}
