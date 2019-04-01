using System;

namespace ConsoleApp4
{
    class Program
    {
        class Bydinki
        {
            private int People;
            private double Square;
            private int Floors;
            public Bydinki(int people, double square, int floors)
            {
                People = people;
                Square = square;
                Floors = floors;
            }
            public static void Square41person(Bydinki bydinok)
            {
                double plosha = 0;
                plosha = bydinok.Square * bydinok.Floors / bydinok.People;
                Console.WriteLine($"Площа на оду людину - {plosha}"); 
            }
        }
        static void Main(string[] args)
        {
            Bydinki budinok = new Bydinki(234, 5000.0, 6);
            Bydinki.Square41person(budinok);
        }
    }
}
