using System;

namespace ConsoleApp1
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
                        for (int i = 1; i <= 20; i += 3)
                        {
                            Console.WriteLine(i);
                            
                        }
                        break;

                    case 2:
                        string d;
                        do
                        {
                            Console.WriteLine("Введіть пароль: ");
                            d = Console.ReadLine();
                        }
                        while (d != "biks");
                        break;

                    case 3:
                        int result = 1;
                        for (int i = 2; i <= 16; i++)
                        {
                            result *= i;
                        }
                        Console.WriteLine($"Добуток цілих чисел від 2 до 16 - {result}");
                        break;

                    case 4:
                        Console.WriteLine("Скільки днів працював робочий?");
                        int Days = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Скільки деталей він виготовив?");
                        int FirstDAY = Int32.Parse(Console.ReadLine());
                        
                        for (int i = 2; i <= Days; i++)
                        {
                            FirstDAY *= 2;
                            Console.WriteLine($"У {i}ий день робочий виготовив {FirstDAY} деталей.");
                        }
                        break;
                    case 5:
                        string aa = "\"Нічого не буває просто так,";
                        string b = "Нічого не буває випадково:";
                        string c = "Ні Зустріч, ні подія, ані слово...";
                        string dd = "До того йшло, або ж це Долі Знак\"";
                        Console.WriteLine(aa);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                        Console.WriteLine(dd);
                        Console.WriteLine();

                        aa = aa.Replace("Нічого не", "Все");
                        b = b.Replace("Нічого не", "Все");
                        int[] OXOXO = { aa.Length, b.Length, c.Length, dd.Length };
                        string it1, it2, it3;
                        if (aa.Length > b.Length) it1 = aa;
                        else it1 = b;
                        if (aa.Length > dd.Length) it2 = c;
                        else it2 = dd;
                        if (it1.Length > it2.Length) it3 = it1;
                        else it3 = it2;
                        Console.WriteLine($"Найдовший рядок - {it3}");
                        Console.WriteLine();

                        Console.WriteLine(aa.Remove(10));
                        Console.WriteLine(b.Remove(3));
                        Console.WriteLine(c.Remove(20));
                        Console.WriteLine(dd.Remove(19));
                        break;
                    case 6:
                        string a1 = "Я хочу, щоб у морі сліз,";
                        string b1 = "У СВІТІ, ДЕ ПАНУЄ ЛИХО,";
                        string c1 = "ПОЕЗІЇ РОСТОЧОК РІС:";
                        string d1 = "Втішав, нагадував і кликав.";
                        Console.WriteLine(a1);
                        Console.WriteLine(b1);
                        Console.WriteLine(c1);
                        Console.WriteLine(d1);
                        Console.WriteLine();

                        Console.WriteLine(a1.ToLower());
                        Console.WriteLine(b1.ToLower());
                        Console.WriteLine(c1.ToLower());
                        Console.WriteLine(d1.ToLower());
                        break;
                    case 7:
                        string stroka = "Login1,LOgin2,login3,loGin4";
                        Console.WriteLine(stroka);
                        string[] stroka1 = stroka.ToLower().Split(',');
                        for (int i = 0; i < stroka1.Length; i++)
                            Console.WriteLine(stroka1[i]);
                        break;
                    case 8:
                        Console.WriteLine("Скільки забили голів господарі?");
                        int Hospodary = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Скільки забили голів гості?");
                        int Hosti = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(Hospodary > Hosti ? "Виграли господарі!" : "Виграли гості!");
                        if (Hosti == Hospodary) Console.WriteLine("Нічия!");
                        break;
                    case 9:
                        int Kratne = 0;
                        while (Kratne!=59136)
                        {
                            Console.WriteLine("Введіть число:");
                            Kratne = Int32.Parse(Console.ReadLine());
                            if (Kratne % 3 == 0 || Kratne % 7 == 0)
                            {
                                if (Kratne % 3 == 0 && Kratne % 7 == 0)
                                {
                                    Console.WriteLine("Число кратне 3-ом і 7-ми");
                                }
                                else Console.WriteLine("Число кратне 3-ом чи 7-ми");
                            }
                            else Console.WriteLine("Число не кратне 3-ом чи 7-ми");
                        }
                        break;
                }
            }
            
        }
    }
}