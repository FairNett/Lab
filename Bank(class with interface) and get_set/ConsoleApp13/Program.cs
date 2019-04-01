using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApp13
{
    class Tovar
    {
        public string name, date;
        double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 10 && value <= 250)
                {
                    price = value;
                }
            }
        }
        int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {

                }
            }
        }

        public Tovar(string name, string date, double price, int amount)
        {
            this.name = name;
            this.date = date;
            this.price = price;
            this.amount = amount;
        }

        static public Tovar TheMostExpensive(Tovar[] tovars)
        {
            for (int i = 0; i < tovars.Length - 1; i++)
            {
                if (tovars[i].Price > tovars[i + 1].Price)
                {
                    Tovar temp = tovars[i];
                    tovars[i] = tovars[i + 1];
                    tovars[i + 1] = temp;
                }
            }
            return tovars[tovars.Length - 1];
        }
    }

    class Posetitel
    {
        public string name;
        public Posetitel(string name)
        {
            this.name = name;
        }
        public void Name() { }
    }

    class Depositer : Posetitel
    {
        public double deposit;
        public Depositer(string name, double deposit):base(name)
        {
            this.deposit = deposit;
        }
        public new void Name()
        {
            Console.WriteLine($"{name}\tДепозит на сумму: {String.Format("{0:c2}", deposit)}");
        }
    }

    class Creditor : Posetitel
    {
        public double credit;
        public Creditor(string name, double credit):base(name)
        {
            this.credit = credit;
        }
        public void Name()
        {
            Console.WriteLine($"{name}\tКредит на сумму: {String.Format("{0:c2}", credit)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.OutputEncoding = System.Text.Encoding.Default;
            while (true)
            {
                Console.WriteLine("Номер задачі: ");
                int a = Int32.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Tovar tovar1 = new Tovar("Pistolet", "10.02.2019", 250, 100);
                        Tovar tovar2 = new Tovar("Rifle", "10.02.2018", 249, 99);
                        Tovar tovar3 = new Tovar("Sniper rifle", "10.02.2017", 248, 98);
                        Tovar tovar4 = new Tovar("Molotov", "10.02.2016", 100, 50);
                        Tovar tovar5 = new Tovar("Grenade", "10.02.2015", 200, 75);
                        Tovar[] tovars = { tovar1, tovar2, tovar3, tovar4, tovar5 };
                        Console.WriteLine("-------------------ТОВАРЫ В КОРЗИНЕ-------------------");
                        for (int i = 0; i < tovars.Length; i++)
                        {
                            Console.WriteLine($"Товар: {tovars[i].name}\nДата выпуска: {tovars[i].date}\nЦена: {tovars[i].Price}\nКоличество: {tovars[i].Amount}\n");
                        }
                        Console.WriteLine($"-----------САМЫЙ ДОРОГОЙ ТОВАР В КОРЗИНЕ-------------\nТовар: {(Tovar.TheMostExpensive(tovars)).name}\nДата выпуска: {(Tovar.TheMostExpensive(tovars)).date}\nЦена: {(Tovar.TheMostExpensive(tovars)).Price}\nКоличество: {(Tovar.TheMostExpensive(tovars)).Amount}\nЦена со скидкой: {(Tovar.TheMostExpensive(tovars)).Price * 0.9}");
                        break;
                    case 2:
                        Depositer[] depositers = new Depositer[1];
                        Creditor[] creditors = new Creditor[1];
                        int j = 0, j1 = 0;
                        bool Bool = true;
                        while (Bool)
                        {
                            Console.Write("Введите имя посетителя банка, что он сделал: депозит(d) или кредит(c), и сумму сделки: ");
                            string Name = Console.ReadLine();
                            if (Name == "exit")
                            {
                                Bool = false;
                                Console.WriteLine("---------------СПИСОК ДЕПОЗИТОРОВ---------------");
                                foreach (Depositer dep in depositers)
                                {
                                    dep.Name();
                                }
                                Console.WriteLine("---------------СПИСОК КРЕДИТОРОВ---------------");
                                foreach (Creditor cred in creditors)
                                {
                                    cred.Name();
                                }
                            }
                            string DorC = Console.ReadLine();
                            double Sum = Double.Parse(Console.ReadLine());
                            if (DorC.ToLower() == "d")
                            {
                                Array.Resize(ref depositers, j+1);
                                depositers[j] = new Depositer(Name, Sum);
                                j++;
                            }
                            else if (DorC.ToLower() == "c")
                            {
                                Array.Resize(ref creditors, j1+1);
                                creditors[j1] = new Creditor(Name, Sum);
                                j1++;
                            }
                        }
                        break;
                }
            }
        }
    }
}