using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            void ReplaceMass(int[] mass)
            {
                foreach (int item in mass) Console.Write(item + "  ");
                for (int i = 0; i < mass.Length; i++) if (mass[i] == 5) mass[i] = 100000;
                Console.WriteLine("\n\n*********Кожна п'ятірка замінюється на 100000*********\n");
                foreach (int item in mass) Console.Write(item + "  ");
                Console.WriteLine();
            }
            int MinThree(int a, int b, int c)
            {
                int min;
                min = a < b ? a : b;
                min = min < c ? min : c;
                return min;
            }
            int Fibonachi(int nomer)
            {
                if (nomer == 1 || nomer == 2) return 1;
                else return Fibonachi(nomer-2) + Fibonachi(nomer-1);

            }
            Random rand = new Random();
            Console.OutputEncoding = System.Text.Encoding.Default;
            while (true)
            {
                Console.WriteLine("Номер задачі: ");
                int a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        int[] mass = new int[25];
                        for (int i = 0; i < 25; i++) mass[i] = rand.Next(1, 11);
                        ReplaceMass(mass);
                        break;
                    case 2:
                        Console.WriteLine("Введіть три числа:");
                        int first = Int32.Parse(Console.ReadLine()), second = Int32.Parse(Console.ReadLine()), third = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"Мінімальним є {MinThree(first, second, third)}");
                        break;
                    case 3:
                        Console.WriteLine($"Введіть номер числа Фібоначчі і отримайте число:");
                        Console.WriteLine(Fibonachi(Int32.Parse(Console.ReadLine())));
                        break;
                }
            }
        }
    }
}