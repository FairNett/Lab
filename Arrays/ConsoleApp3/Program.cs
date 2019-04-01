using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine("Номер задачі: ");
                int a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        int m, n;
                        Console.WriteLine("Кількість рядків:");
                        m = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Кількість стовпців:");
                        n = Int32.Parse(Console.ReadLine());
                        int[,] arr = new int[m, n];
                        for (int i = 0; i < m; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                arr[i, j] = rand.Next(10);
                                Console.Write(arr[i, j]+"   ");
                            }
                            Console.WriteLine();
                        }
                        
                        int sum = 0;
                        for (int i = 0; i<n; i++)
                        {
                            if (i % 2 == 1)
                            {
                                for (int j = 0; j < m; j++)
                                {
                                    sum += arr[j, i];
                                }
                                Console.WriteLine($"Сума елементів рядка №{i+1} дорівнює {sum}");
                                sum = 0;
                            }

                        }
                        break;

                    case 2:
                        int d;
                        Console.WriteLine("Введіть кількість масивів:");
                        d = Int32.Parse(Console.ReadLine());
                        int[][] Arr = new int[d][];
                        Console.WriteLine("Введіть розмір кожного масиву:");
                        for(int i = 0; i<d; i++)
                        {
                            Console.WriteLine($"Введіть розмір масиву №{i+1}:");
                            int q = Int32.Parse(Console.ReadLine());
                            Arr[i] = new int[q];
                            Console.WriteLine("Введіть значення елементів цього масиву:");
                            for(int j = 0; j<q; j++)
                            {
                                Arr[i][j] = Int32.Parse(Console.ReadLine());
                            }
                        }
                        Console.WriteLine("Даний ступінчатий масив:");
                        for(int i = 0; i<d; i++)
                        {
                            for(int j = 0; j<Arr[i].Length; j++)
                            {
                                Console.Write(Arr[i][j] + "   ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        int[][] arr1 = new int[5][];
                        arr1[0] = new[] { 0 };
                        arr1[1] = new[] { 1, 0 };
                        arr1[2] = new[] { 2, 1, 0 };
                        arr1[3] = new[] { 3, 2, 1, 0 };
                        arr1[4] = new[] { 4, 3, 2, 1, 0 };
                        int[][] arr2 = new int[5][];
                        arr2[0] = new[] { 30 };
                        arr2[1] = new[] { 29, 30 };
                        arr2[2] = new[] { 28, 29, 30 };
                        arr2[3] = new[] { 27, 28, 29, 30 };
                        arr2[4] = new[] { 26, 27, 28, 29, 30 };
                        int[][] arr3 = new int[5][];
                        arr3[4] = new[] { 2 };
                        arr3[3] = new[] { 3, 2 };
                        arr3[2] = new[] { 4, 3, 2 };
                        arr3[1] = new[] { 5, 4, 3, 2 };
                        arr3[0] = new[] { 6, 5, 4, 3, 2 };
                        int[][] arr4 = new int[5][];
                        arr4[4] = new[] { 16 };
                        arr4[3] = new[] { 17, 18 };
                        arr4[2] = new[] { 18, 19, 20 };
                        arr4[1] = new[] { 19, 20, 21, 22 };
                        arr4[0] = new[] { 20, 21, 22, 23, 24 };
                        for(int i = 0; i<5; i++)
                        {
                            for(int j = 0; j<arr1[i].Length; j++)
                            {
                                Console.Write(arr1[i][j] + "   ");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < arr2[i].Length; j++)
                            {
                                Console.Write(arr2[i][j] + "   ");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < arr3[i].Length; j++)
                            {
                                Console.Write(arr3[i][j] + "   ");
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < arr4[i].Length; j++)
                            {
                                Console.Write(arr4[i][j] + "   ");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 4:
                        int sum6x6 = 0, g=0;
                        int[,] arr6x6 = new int[6, 6];
                        int[] SMbls36 = new int[36];
                        Console.WriteLine("Введіть 36 чисел масива:");
                        string smbls36 = Console.ReadLine();
                        string[] Smbls36 = smbls36.Split();
                        for (int i = 0; i<36; i++)
                        {
                            SMbls36[i] = Int32.Parse(Smbls36[i]);
                        }
                        for (int i = 0; i<6; i++)
                        {
                            for(int j = 0; j<6; j++)
                            {
                                arr6x6[i,j]=SMbls36[g];
                                g++;
                            }
                        }
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                Console.Write("\t" + arr6x6[i, j]);
                            }
                            Console.WriteLine();
                        }
                        for (int i = 0; i < 6; i++)
                            for (int j = 0; j < 6; j++)
                                if (arr6x6[i, j] % 3 == 0) sum6x6 += arr6x6[i, j];
                        Console.WriteLine($"Сума чисел кратних 3 - {sum6x6}");
                        break;
                    case 5:
                        int sum2x41=0, sum2x42=0;
                        int[,] arr2x4 = new int[2, 4] { { 2, 3, 6, 9}, { 5, 8, 1, 3} };
                        for (int i = 0; i < 2; i++)
                        {
                            sum2x41 += arr2x4[i, 1];
                            sum2x42 += arr2x4[i, 3];
                            for (int j = 0; j < 4; j++)
                                Console.Write("\t" + arr2x4[i, j]);
                            Console.WriteLine();
                        }
                        Console.WriteLine($"Сума чисел другого стовпчика - {sum2x41}; сума чисел четвертого стовпчика - {sum2x42}.");
                        break;
                    case 6:
                        int[] A = new int[9];
                        int sumA = 0, dobA=1;
                        for (int i = 0; i < 9; i++)
                        {
                            A[i] = rand.Next(-100, 100);
                            Console.Write(A[i] + "   ");
                            sumA += A[i];
                            if (A[i] > 0) dobA *= A[i];
                        }
                        Console.WriteLine($"Середнє арифметичне - {sumA/9}; добуток додатніх чисел - {dobA}.");
                        break;
                }
            }
        }
    }
}