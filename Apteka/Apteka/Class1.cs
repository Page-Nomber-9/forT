using System;
using System.Collections.Generic;
using System.Text;

namespace Apteka
{
    class Ap
    {
        List<string> namele = new List<String>() {"Ламизил", "Амброксол", "йодомарин", "Панангин", "Финлепсин"};
        //моя программа, что хочу то ворочу
        string nameap="АХАХАХАХАХАХАХАХАХАХ";
        List<int> cost = new List<int>() {390, 40, 256, 170, 242};
        public void Showinf()
        {
            Console.WriteLine($"в компании {nameap} есть такие припараты:");
            Ap a = new Ap();
            for (int i=0; i<a.cost.Count;i++)
            {
                Console.WriteLine($"{a.namele[i]}({a.cost[i]}руб.), ");
            }
        }
        public void Maxcost()
        {
            Ap a = new Ap();
            int k = 0;
            int m = a.cost[0];
            for (int i=0; i < a.cost.Count; i++)
            {
                if (m<a.cost[i])
                {
                    m = a.cost[i];
                    k = i;
                }
            }
            Console.WriteLine($"самый дорогой припарат - {m}({k}руб.)");
        }
        public void Allcost()
        {
            Ap a = new Ap();
            int m = 0;
            for (int i = 0; i < a.cost.Count; i++)
            {
                m = m + a.cost[i];
            }
            Console.WriteLine($"общая стоимость всех припаратов - {m}руб.");
        }
    }


}
