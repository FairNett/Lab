using System;
using System.IO;

namespace ConsoleApp7
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
                        string path = @"D:\4 семестр\ТПЗІ\group.txt";
                        Console.WriteLine("******Записуємо у файл********");
                        using (StreamWriter sr = new StreamWriter(path))
                        {
                            sr.Write("1");
                            for (int i = 2; i < 524; i++) sr.Write($", {i}");
                        }
                        Console.WriteLine("\n******Робота завершена********");
                        break;
                    case 2:
                        string[] mass = { "Кобзар", "Марія", "Заповіт", "Словник", "Інформатика" };
                        string path1 = @"D:\4 семестр\ТПЗІ\group1.txt";
                        Console.WriteLine("******Записуємо у файл********");
                        using (StreamWriter sr = new StreamWriter(path1))
                        {
                            for (int i = 0; i < mass.Length; i++) sr.WriteLine($"{mass[i]}");
                        }
                        Console.WriteLine("\n******Робота завершена********");
                        break;
                    case 3:
                        string[] mass1= new string[5];
                        string temp;
                        string path2 = @"D:\4 семестр\ТПЗІ\group1.txt";
                        Console.WriteLine("******Зчитуємо з файла********");
                        using (StreamReader sr = new StreamReader(path2))
                        {
                            for (int i = 0; i < mass1.Length; i++)
                            {
                                mass1[i] = sr.ReadLine();
                                Console.WriteLine(mass1[i]);
                            } 
                        }
                        for (int i = 0; i < mass1.Length-1; i++)
                        {
                            if (mass1[i].Length > mass1[i + 1].Length)
                            {
                                temp = mass1[i];
                                mass1[i] = mass1[i + 1];
                                mass1[i + 1] = temp;
                            }  
                        }
                        Console.WriteLine($"\nНайдовшим рядком є - {mass1[4]}");
                        Console.WriteLine("\n******Робота завершена********");
                        break;
                }
            }
        }
    }
}