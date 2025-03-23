using System;
using System.Runtime.CompilerServices;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TestProject1"), InternalsVisibleTo("GUI")]

namespace ConsoleApp1
{
    class Result
    {
        public List<int> FinalItems;
        public int waga_sum { get; set; }
        public int wartosc_sum { get; set; }
        public int wagaAll { get; set; }
        public int wartoscAll { get; set; }

        public Result(List<int> _items, int _waga, int _wartosc, int _wartoscAll, int _wagaAll)
        {
            FinalItems = _items;
            waga_sum = _waga;
            wartosc_sum = _wartosc;
            wagaAll = _wagaAll;
            wartoscAll = _wartoscAll;

        }

        public override string ToString()
        {
            return $"Wybrane przedmioty: {string.Join(", ", FinalItems)}\n" +
                   $"Sumaryczna wartość: {wartosc_sum}\n" +
                   $"Sumaryczna waga: {waga_sum}\n" +
                   $"Calkowita waga przedmiotow: {wagaAll}\n" +
                   $"Całkowita wartosc przedmiotow: {wartoscAll}";

        }
    }
    
}