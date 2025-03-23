using System;
using System.Runtime.CompilerServices;
[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("TestProject1"), InternalsVisibleTo("GUI")]

namespace ConsoleApp1
{
    class Items
    {
        public int indeks { get; set; }
        public int waga { get; set; }
        public int wartosc { get; set; }
        public double proportion { get; set; }

        public Items(int Indeks, int Waga, int Wartosc)
        {
            indeks = Indeks;
            waga = Waga;
            wartosc = Wartosc;
            proportion = (double)Wartosc / Waga;
        }

        public override string ToString()
        {
            return $"Item {indeks}: Waga = {waga}, Wartosc = {wartosc}, Stosunek = {proportion:F2}";
        }
    }
}
