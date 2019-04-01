using System;
using System.Text;
using System.IO;
using System.Globalization;
using System.Threading;

namespace ConsoleApp9
{
    class Car
    {
        public string Model { private set; get; }
        public DateTime Date { private set; get; }
        public string Color { private set; get; }
        public string Type { private set; get; }
        public double Price { private set; get; }

        public Car(string model, DateTime date, string color, string type, double price)
        {
            Model = model;
            Date = date;
            Color = color;
            Type = type;
            Price = price;
        }

        public static void OldCar(Car[] args)
        {
            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].Date.AddYears(1) < DateTime.Now) Console.WriteLine($"Модель: {args[i].Model}\nКолір: {args[i].Color}\nЦіна: {String.Format("{0:c2}", args[i].Price)}\n************СТАРА************");
                }
            }
            catch (Exception) { Console.WriteLine("Машин немає."); }
        }
        public static void ReviewCar(Car[] args)
        {
            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine($"Модель: {args[i].Model}\nКолір: {args[i].Color}\nЦіна: {String.Format("{0:c2}", args[i].Price)}\nТип: {args[i].Type}\nДата виробництва: {args[i].Date.ToShortDateString()}\n");
                }
            }
            catch (Exception) { Console.WriteLine("Машин немає."); }
        }
        public static void GreenCar(Car[] args)
        {
            try
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].Color.ToLower() == "green") Console.WriteLine($"Модель: {args[i].Model}\nДата виробництва: {args[i].Date.ToShortDateString()}\nЦіна: {String.Format("{0:c2}", args[i].Price)}");
                }
            }
            catch (Exception) { Console.WriteLine("Машин немає."); }
}
        public static void TheMostExpensiveCar(Car[] args)
        {
            try
            {
                Car temp;
                for (int i = 0; i < args.Length - 1; i++)
                {
                    if (args[i].Price > args[i + 1].Price)
                    {
                        temp = args[i];
                        args[i] = args[i + 1];
                        args[i + 1] = temp;
                    }
                }
                Console.WriteLine($"Модель: {args[args.Length - 1].Model}\nДата виробництва: {args[args.Length - 1].Date.ToShortDateString()}\nЦіна: {String.Format("{0:c2}", args[args.Length - 1].Price)}\nКолір: {args[args.Length - 1].Color}\nТип: {args[args.Length - 1].Type}");
            }
            catch (Exception) { Console.WriteLine("Машин немає."); }
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.OutputEncoding = Encoding.Default;
            Random rand = new Random();
            while (true)
            {
                Console.WriteLine("Номер задачі: ");
                int a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        int first = 0, second = 0;
                        bool CHECK = true;
                        int[] mass = new int[10];
                        for (int i = 0; i < 10; i++)
                        {
                            mass[i] = rand.Next(1, 11);
                            Console.Write(mass[i] + "\t");
                        }
                        Console.WriteLine("\nВведіть номера ваших елементів:");
                        while (CHECK)
                        {
                            try
                            {
                                try
                                {
                                    first = Int32.Parse(Console.ReadLine());
                                    if (first <= 9 && first >= 0) CHECK = false;
                                    else throw new Exception("Число більше 9 або від'ємне.");
                                }
                                catch
                                {
                                    Console.WriteLine("Возникло исключение");
                                    throw;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        CHECK = true;
                        while (CHECK)
                        {
                            try
                            {
                                try
                                {
                                    second = Int32.Parse(Console.ReadLine());
                                    if (second <= 9 && second >= 0) CHECK = false;
                                    else throw new Exception("Число більше 9 або від'ємне.");
                                }
                                catch
                                {
                                    Console.WriteLine("Виникла помилка.");
                                    throw;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        using (StreamWriter sw = new StreamWriter(@"D:\4 семестр\ТПЗІ\laba9.txt", false, Encoding.Default))
                        {
                            foreach (int item in mass)
                            {
                                sw.Write(item + "\t");
                            }
                            sw.WriteLine($"\nСума {first}го i {second}го елементів дорівнює {mass[first] + mass[second]}.");
                        }
                        Console.WriteLine($"\nСума {first}го i {second}го елементів дорівнює {mass[first] + mass[second]}.");
                        break;
                    case 2:
                        bool Bool = true;
                        Console.WriteLine("********************АВТОСАЛОН ВІДКРИТИЙ**********************");
                        int numerator = 0;
                        Car[] Autosaloon = new Car[3];
                        while (Bool)
                        {
                            Console.Write("Введіть модель машини або \"no\", якщо не хочете додати нову машину в автосалон: ");
                            string Name = Console.ReadLine();
                            string Model = Name;
                            
                            if (Name.ToLower() != "no")
                            {
                                
                                Console.WriteLine("Дата виробництва машини [рік, місяць, день]: ");
                                int year = Int16.Parse(Console.ReadLine()), month = Int16.Parse(Console.ReadLine()), day = Int16.Parse(Console.ReadLine());
                                DateTime Date = new DateTime(year, month, day);
                                Console.WriteLine("Колір машини: ");
                                string Color = Console.ReadLine();
                                Console.WriteLine("Тип машини: ");
                                string Type = Console.ReadLine();
                                Console.WriteLine("Ціна машини: ");
                                double Price = Double.Parse(Console.ReadLine());
                                Autosaloon[numerator] = new Car(Model, Date, Color, Type, Price);
                                numerator++;
                            }
                            else
                            {
                                Bool = false;
                            }
                        }
                        Console.WriteLine("*******************МАШИНИ ЗЕЛЕНОГО КОЛЬОРУ******************");
                        Car.GreenCar(Autosaloon);
                        Console.WriteLine("*****************МАШИНАМ БІЛЬШЕ ОДНОГО РОКУ*****************");
                        Car.OldCar(Autosaloon);
                        Console.WriteLine("***********************ПЕРЕГЛЯД МАШИН***********************");
                        Car.ReviewCar(Autosaloon);
                        Console.WriteLine("**********************НАЙДОРОЖЧА ТАЧКА**********************");
                        Car.TheMostExpensiveCar(Autosaloon);
                        Console.WriteLine("********************АВТОСАЛОН ЗАЧИНЕНО**********************\n");
                        break;
                }
            }
        }
    }
}