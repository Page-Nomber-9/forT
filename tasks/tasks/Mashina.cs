using System;
using System.Collections.Generic;
using System.Text;

namespace tasks
{
    class Mashina
    {
        List<string> nomb = new List<string>() {"К999МА", "Е005АМ", "В802ОР"};
        List<string> mark = new List<string>() {"Ford", "Nissan", "Toyota"};
        List<string> model = new List<string>() {"Focus", "Almera", "Camry"};
        public void Start(in string x)
        {
        Mashina mash = new Mashina();       
        int i = mash.model.IndexOf(x);
        Console.WriteLine($"Машина {mash.mark[i]} {mash.model[i]} завелась ;)");
                
            
        }
        public void Stop(in string x)
        {
         Mashina mash = new Mashina();
        int i = mash.model.IndexOf(x);
         Console.WriteLine($"Машина {mash.mark[i]} {mash.model[i]} остановилась ;)");
        }
    }
}
