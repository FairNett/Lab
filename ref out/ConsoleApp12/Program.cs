using System;

namespace ConsoleApp12
{
    class Program
    {
        static public Random rnd = new Random();
        static void Replace(ref string str1, ref string str2)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }
        static void LastEx(out double a, out double b, out double c, out double d)
        {
            a = rnd.Next(10,100)+rnd.NextDouble();
            b = Math.Truncate(a);
            c = b % 2 == 0 ? 0 : 1;
            d = a - b;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Номер задачи: ");
                int a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Write($"Исходное число: ");
                        double A = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Целая часть числа: {Math.Truncate(A)}");
                        Console.WriteLine($"Дробная часть числа: {Math.Round(A - Math.Truncate(A), 3)}");
                        Console.WriteLine($"Квадрат числа: {Math.Pow(A, 2)}");
                        Console.WriteLine($"Куб числа: {Math.Pow(A, 3)}");
                        Console.WriteLine($"Квадратный корень числа: {Math.Sqrt(A)}");
                        break;
                    case 2:
                        string str1 = "Однажды в студеную зимнюю пору я из лесу вышел. Был силный мороз.";
                        string str2 = "Гляжу, поднимается медленно в гору лошадка, везущая хваросту воз.";
                        Console.WriteLine($"\tНачальные строчки s1 и s2:\n{str1}\n{str2}\ns1 =\n{str1}\ns2 =\n{str2}\n");
                        Replace(ref str1, ref str2);
                        Console.WriteLine($"\tКонечные строчки s1 и s2:\n{str1}\n{str2}");
                        break;
                    case 3:
                        double k1;
                        double k1a;
                        double k1d;
                        double k1d1;
                        LastEx(out k1, out k1a, out k1d, out k1d1);
                        Console.WriteLine($"k1 = {k1}\ta = {k1a}\td = {k1d}\td1 = {k1d1}\n");
                        LastEx(out k1, out k1a, out k1d, out k1d1);
                        Console.WriteLine($"k1 = {k1}\ta = {k1a}\td = {k1d}\td1 = {k1d1}\n");
                        LastEx(out k1, out k1a, out k1d, out k1d1);
                        Console.WriteLine($"k1 = {k1}\ta = {k1a}\td = {k1d}\td1 = {k1d1}\n");
                        LastEx(out k1, out k1a, out k1d, out k1d1);
                        Console.WriteLine($"k1 = {k1}\ta = {k1a}\td = {k1d}\td1 = {k1d1}\n");
                        break;
                }
            }
        }
    }
}