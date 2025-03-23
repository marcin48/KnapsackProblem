using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TestProject1"), InternalsVisibleTo("GUI")]


namespace ConsoleApp1
{

    class BackpackProblem
    {
        private int N;
        private List<Items> items;

        public BackpackProblem(int value, int seed)
        {
            N = value;
            items = new List<Items>();
            Random random = new Random(seed);

            for(int i = 0; i < N; i++)
            {
                int waga = random.Next(1, 21);
                int wartosc = random.Next(1, 21);
                items.Add(new Items(i + 1, waga, wartosc));
            }

        }

        //Dodane przez MVS
        public List<Items> Items
        {
            get { return items; }
        }

        //Dodane przez MVS
        public void SetItems(List<Items> customItems)
        {
            items = customItems;
        }

        public void ShowBackpack()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public Result Solve(int capacity)
        {
            List<int> ChosenItems = new List<int>();
            int _wartoscSum = 0;
            int _wagaSum = 0;
            int waga_all = 0;
            int wartosc_all = 0;
            List<Items> Sorted = items.OrderByDescending(p => (double) p.wartosc / p.waga).ToList();

            foreach(var item in Sorted)
            {
                waga_all += item.waga;
                wartosc_all += item.wartosc;
                if(_wagaSum + item.waga <= capacity)
                {
                    ChosenItems.Add(item.indeks);
                    _wartoscSum += item.wartosc;
                    _wagaSum += item.waga;
                }
            }

            Console.WriteLine("\nSorted items:");
            foreach (var item in Sorted)
            {
                Console.WriteLine(item);
            }

            return new Result(ChosenItems, _wagaSum, _wartoscSum, waga_all, wartosc_all);
        }



        public override string ToString()
        {
            
            return string.Join("\n", items.Select(p => $"Przedmiot {p.indeks}: Waga = {p.waga}, Wartosc = {p.wartosc}, Stosunek = {(double)p.wartosc / p.waga:F2}"));
        }


    }
}