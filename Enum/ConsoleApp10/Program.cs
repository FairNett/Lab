using System;

namespace ConsoleApp10
{
    class Coffee
    {
        public enum KABA
        {
            brewed_coffee = 1,
            instant_coffee,
            decaffeinated_coffee,
            espresso,
            americano,
            kapuchino,
            mokachino
        }
         static public void KABAXJlEb(KABA kava)
        {
            switch (kava)
            {
                case KABA.brewed_coffee:
                    Console.WriteLine("Уровень кофеина в 250 мл заварного кофе - 95-200 мг");
                    break;
                case KABA.instant_coffee:
                    Console.WriteLine("Уровень кофеина в 250 мл растворимого кофе - 30-200 мг");
                    break;
                case KABA.decaffeinated_coffee:
                    Console.WriteLine("Уровень кофеина в 250 мл кофе без кофеина - 2-30 мг");
                    break;
                case KABA.espresso:
                    Console.WriteLine("Уровень кофеина в 30 мл эспрессо - 40-75 мг");
                    break;
                case KABA.americano:
                    Console.WriteLine("Уровень кофеина в 250 мл американо - 80-150 мг");
                    break;
                case KABA.kapuchino:
                    Console.WriteLine("Уровень кофеина в 250 мл капучино - 40-75 мг");
                    break;
                case KABA.mokachino:
                    Console.WriteLine("Уровень кофеина в 250 мл мокачино - 40-75 мг");
                    break;
                default:
                    break;
            }
        }
    }
    class Program
    {
        enum Products
        {
            borshch = 1,
            potato,
            pork,
            vegetables,
            apple,
            banana,
            pomelo,
            tea,
            coffee
        }
        static void Fitonjashka(Products product)
        {
            switch (product)
            {
                case Products.borshch:
                    Console.WriteLine("Красотка, за 100 г борща ты наберешь всего 49 ккал.");
                    break;
                case Products.potato:
                    Console.WriteLine("Красотка, за 100 г картошки ты наберешь всего 77 ккал.");
                    break;
                case Products.pork:
                    Console.WriteLine("Красотка, за 100 г жареной свинины ты наберешь всего 242 ккал.");
                    break;
                case Products.vegetables:
                    Console.WriteLine("Красотка, за 100 г овощей ты наберешь всего 65 ккал.");
                    break;
                case Products.apple:
                    Console.WriteLine("Красотка, за 100 г яблок ты наберешь всего 52 ккал.");
                    break;
                case Products.banana:
                    Console.WriteLine("Красотка, за 100 г бананов ты наберешь всего 89 ккал.");
                    break;
                case Products.pomelo:
                    Console.WriteLine("Красотка, за 100 г помело ты наберешь всего 38 ккал.");
                    break;
                case Products.tea:
                    Console.WriteLine("Красотка, за 250 г чая ты наберешь всего 2,5 ккал.");
                    break;
                case Products.coffee:
                    Console.WriteLine("Красотка, за 100 г експрессо ты наберешь всего 9 ккал.");
                    break;
            }
        }

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
                        Products product;
                        for (product = Products.borshch; product <= Products.coffee; product++)
                            Fitonjashka(product);
                        break;
                    case 2:
                        Coffee.KABA kava;
                        for (kava = Coffee.KABA.brewed_coffee; kava <= Coffee.KABA.mokachino; kava++)
                        {
                            Coffee.KABAXJlEb(kava);
                        }
                        break;
                }
            }
        }
    }
}