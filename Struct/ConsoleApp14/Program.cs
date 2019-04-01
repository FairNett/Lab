using System;

namespace ConsoleApp14
{
    struct Radius
    {
        int SR, temp;
        public int SearchR(int[] mass)
        {
            int[] Mass = new int[mass.Length];
            for (int i = 0; i<mass.Length; i++)
            {
                SR += mass[i];
            }
            SR = SR / mass.Length;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i]-=SR;
            }
            Console.WriteLine("\nСреднее - "+SR);
            for (int j = 0; j <mass.Length; j++)
            {
                for (int i = 0; i < mass.Length - 1; i++)
                {
                    if (Math.Abs(mass[i]) > Math.Abs(mass[i + 1]))
                    {
                        temp = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] += SR;
            }
            return mass[0];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] Mass = { 5, 6, 3, 8, 34, 12, 10, 43, 9 };
            foreach (int item in Mass)
            {
                Console.Write(item+"\t");
            }
            Radius radius = new Radius();
            int rad = radius.SearchR(Mass);
            Console.WriteLine($"Радиус максимально близкий к среднему значению радиусов окружностей со списка - {rad}. Длинна окружности составляет - {2*Math.PI*rad}.");
        }
    }
}