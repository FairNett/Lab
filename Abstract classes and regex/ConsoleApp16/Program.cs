using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp16
{
    abstract class CafeNet
    {
        public string Name { get; set; }
        public abstract void Podjaka();
    }
    class Ukr: CafeNet
    {
        public Ukr(string name)
        {
            Name = name;
        }
        public override void Podjaka()
        {
            Console.WriteLine("Подяка у вигляді страви \"Вареники з картоплею і шкварками.\"");
        }
    }
    class Eu : CafeNet
    {
        public Eu(string name)
        {
            Name = name;
        }
        public override void Podjaka()
        {
            Console.WriteLine("Thanksgiving in the form of a Sour cream cake.");
        }
    }
    class Georgia : CafeNet
    {
        public Georgia(string name)
        {
            Name = name;
        }
        public override void Podjaka()
        {
            Console.WriteLine("Thanksgiving in the form of a Adjar khachapuri.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            Ukr ukr = new Ukr("Варенички");
            Eu eu = new Eu("Tartlets");
            Georgia geo = new Georgia("Khachapuri");
            ukr.Podjaka();
            eu.Podjaka();
            geo.Podjaka();
            Console.WriteLine();

            Console.WriteLine("Введите логин:\nЗнайте,что логин должен содержать цифры и 2-10 символов. Логин не может начинаться и заканчиваться цифрой.");
            string login = Console.ReadLine();
            Regex requirements = new Regex(@"[0-9a-zA-Z_]");
            if (login.Length < 2 || login.Length > 10) Console.WriteLine("Нікнейм не підходить. Стежте за довжиною.");
            else
            {
                Regex myreg = new Regex(@"[0-9]");
                if (myreg.IsMatch(login[0].ToString()) || myreg.IsMatch(login[login.Length-1].ToString())) Console.WriteLine("Нікнейм не підходить. Неможливі цифри на початку і в кінці.");
                else Console.WriteLine(requirements.IsMatch(login));
            }

            int[] f = { -1, 4, 3, 4, 8, 6 };    //з масиву f з 2 по 5 елемент,
            int[] r = { -3, 8, 2, -4 };         //з масиву r з 0 по 3 елемент,
            int[] fi = { -1, 5, -3, 4, 1, 6 };  //з масиву fi з 0 по 1 елемент,
            int[] rt = { -5, 6, 9, -1 };        //з масиву rt з 1 по 3 елемент.
            var Segments = new ArraySegment<int>[4]
            {
                new ArraySegment<int>(f,2,4),
                new ArraySegment<int>(r),
                new ArraySegment<int>(fi,0,2),
                new ArraySegment<int>(rt,1,3)
            };
            Console.WriteLine("\nСумма выбранных значений равна:\n" + SumArraySegments(Segments));
        }
        static int SumArraySegments(ArraySegment<int>[] value)
        {
            int sum = 0;
            foreach (var s in value)
                for (int i = s.Offset; i < s.Offset + s.Count; i++)
                {
                    if (s.Array[i]>0)
                    {
                        sum += s.Array[i];
                    }
                }
            return sum;
        }
    }
}