using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            while (true)
            {
                Console.WriteLine("Номер задачі: ");
                int a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        int[][] Mass = new int[4][];
                        Mass[0] = new int[] { 2, 3, 4, 5, 1, 7, 8, 9 };
                        Mass[1] = new int[] { 2, 3, 4, 6, 7, 8 };
                        Mass[2] = new int[] { 1, 2, 3, 4, 0 };
                        Mass[3] = new int[] { 1, 2, 4 };
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < Mass[i].Length; j++)
                            {
                                Console.Write(Mass[i][j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();

                        Array.Sort(Mass[0]);
                        Array.Sort(Mass[1]);
                        Array.Sort(Mass[2]);
                        Array.Sort(Mass[3]);
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < Mass[i].Length; j++)
                            {
                                Console.Write(Mass[i][j] + "\t");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        string[] Students = new string[] { "Студент: Моклякова.\tВік: 18.", "Студент: Мухайдлі.\tВік: 18.", "Студент: Сарока.\tВік: 18.", "Студент: Скрипник.\tВік: 18.", "Студент: Качмала.\tВік: 18.", "Студент: Євенко.\tВік: 18.",
                                                           "Студент: Жолнер.\tВік: 18.", "Студент: Гулаков.\tВік: 18.", "Студент: Андрейчук.\tВік: 19.", "Студент: Золотарьов.\tВік: 19.", "Студент: Ковальчук.\tВік: 19.", "Студент: Кольцов.\tВік: 19.",
                                                           "Студент: Купріна.\tВік: 19.", "Студент: Майборода.\tВік: 19.", "Студент: П’ятниця.\tВік: 19.", "Студент: Андрусяк.\tВік: 19.", "Студент: Архипов.\tВік: 19.", "Студент: Блохіна.\tВік: 19.",
                                                           "Студент: Галась.\tВік: 19.", "Студент: Гедеон.\tВік: 20.", "Студент: Рой.\tВік: 20." };
                        for (int i = 0; i<21; i++)
                        {
                                Console.WriteLine(Students[i]);
                        }
                        Array.Sort(Students);
                        Console.WriteLine();
                        for (int i = 0; i < 21; i++)
                        {
                            Console.WriteLine(Students[i]);
                        }
                        break;
                }
            }
        }
    }
}
