using System;

namespace ConsoleApp2
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
                        string s1 = "Начальнику служби", s2 = " охорони", s3 = "Петрову С.Г.", s4 = "Службова записка", s5 = "Прошу дати наказ охороні університету видавати ключі від кімнати студентської ради (к.345) тільки голові студентської ради.", s6 = "Декан інформаційних технологій", s7 = "Сергієв К.Г.";
                        Console.WriteLine(s1 + s2 + "\n" + s3 + "\n" + "\n" + "\n" + s4 + "\n" + "\n" + s5 + "\n" + "\n" + s6 + "         " + s7);
                        s1 = s1.PadLeft(60);
                        s2 = s2.PadLeft(50);
                        s3 = s3.PadLeft(55);
                        s4 = s4.PadLeft(40);
                        s5 = s5.PadLeft(10);
                        s5 = s5.Replace("345", "201");
                        s5 = s5.Replace("студентської ради", "студ. ради Теневичу П.С");
                        s6 = s6.Replace("Декан інформаційних технологій", "Проректор");
                        s7 = s7.Replace("Сергієв К.Г.", "з впровадження інформаційних технологій          Іванов К.Г.");
                        Console.WriteLine(s1 + "\n" + s2 + "\n" + s3 + "\n" + "\n" + s4 + "\n" + "\n" + s5 + "\n" + "\n" + s6 + "\n" + s7);
                        break;
                    case 2:
                        string A = Console.ReadLine();
                        string B = Console.ReadLine();
                        Console.WriteLine(A[0] + "\n" + A[4]);
                        for (int i = 0; i < 10; i++)
                            Console.Write(A[i]);
                        Console.WriteLine("\n" + B[0]);
                        break;
                    case 3:
                        Random rnd = new Random();
                        int[,] Mass = new int[9, 5];
                        int f = 1;
                        for (int i = 0; i < 9; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Mass[i, j]=f;
                                f++;
                                Console.Write(Mass[i,j]+ "\t");
                            }
                            Console.WriteLine();
                        }
                        int Sred = 0;
                        for(int i = 0; i<9; i++)
                        {
                            Sred += Mass[i, 2];
                        }
                        Console.WriteLine((Sred-3)/8);
                        break;
                    case 4:
                        string[] mas = { "Життя – це посмішка уранці,",
                           "Це фотографія у рамці,",
                            "Життя – це посмішка крізь сльози,",
                            "Життя – це сонце і морози!",
                            "Життя – це квіти навесні,",
                            "Життя – це жарти і пісні.",
                            "Життя – це кайф, як не крути,",
                            "Його нам варто перейти!" };
                        for (int i = 0; i < mas.Length; i++)
                        {
                            Console.WriteLine(mas[i]);
                        }
                        Console.WriteLine();
                        for(int i = 0; i<mas.Length; i++)
                        {
                            for(int j = 0; j<mas[i].Length; j++)
                            {
                                Console.Write(mas[i][mas[i].Length - j-1]);
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        for (int i = 0; i < mas.Length; i++)
                        {
                            if (mas[i].Contains("Життя"))
                            {
                                Console.WriteLine(mas[i]);
                            }
                        }
                        break;
                    case 5:
                        for (int i = 1; i < 76; i++)
                        {
                            if (i%5==0)
                            {
                                Console.Write("БІКС\t");
                            }
                            else Console.Write(i+"\t");
                        }
                        break;
                    case 6:
                        int[,] ARR = new int[3, 3];
                        int sUm = 0, sum1 = 0;
                        int F = 1;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j <3; j++)
                            {
                                ARR[i, j] = F;
                                F++;
                                Console.Write(ARR[i,j]+"\t");
                                sUm += ARR[i, j];
                                sum1 += ARR[i, j] * ARR[i, j];
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine(sUm);
                        Console.WriteLine(sum1);
                        Console.WriteLine(sUm/9);
                        break;
                    case 7:
                        string[] LastName = { "Кузин", "Куравлевfgh", "Кудинfhgj", "Кульковjf", "Кубиковty",
                        "Кузинxfb", "Куравлев", "Кудинnghs", "Кульковsrn", "Кубикоdtyв",
                        "Кузинdndnty", "Куравлевytnty", "Кудин", "Кулькоfgndв", "Кубиxfgbxgfков",
                        "Кузинxfgbxfg", "Куравлевbxfgb", "Кудинxfgbx", "Кульков", "Кубиковxfgbfxg",
                        "Кузинxfgbdgb", "Куравлевghncgh", "Кудинcghnc", "Кульковcghnch", "Кубиков",
                        "Кузинgchns", "Куравлевbdxftgxb", "Кудинxfgbxft", "Кульковzsdfv", "Кубиковваитрп"};
                        for (int i = 0; i < LastName.Length; i++)
                        {
                            if (LastName[i] == "Кузин" || LastName[i] == "Куравлев" || LastName[i] == "Кудин" || LastName[i] == "Кульков" || LastName[i] == "Кубиков")
                            {
                                Console.WriteLine(LastName[i] + ". Он живет на ...");
                            }
                            else Console.WriteLine(LastName[i]);
                            Console.WriteLine();
                        }
                        break;
                    case 8:
                        int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
                        nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
                        nums = new int[19] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
                        int suma1 = 0, dobutok = 1;
                        for (int i = 0; i < nums.Length; i++)
                        {
                            suma1 += nums[i];
                            dobutok *= nums[i];
                        }
                        Console.WriteLine($"Сума елементів дорівнює {suma1}\nДобуток елементів дорівнює {dobutok}");
                        break;
                    case 9:
                        int[] NUMS = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        for (int i = 0; i < NUMS.Length; i++)
                        {
                            Console.WriteLine(NUMS[i]*NUMS[i]);
                        }
                        break;
                }
            }

        }
    }
}