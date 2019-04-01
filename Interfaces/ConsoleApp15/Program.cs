using System;
using System.Text;

namespace ConsoleApp15
{
    public interface IPult
    {
        void Vkl();
        void Vukl();
        void Pause();
    }
    public interface ICount
    {
        int Ser();
    }
    class TV: IPult
    {
        public void Vkl()
        {
            Console.WriteLine("Телевізор увімкнено.");
        }
        public void Vukl()
        {
            Console.WriteLine("Телевізор вимкнено.");
        }
        public void Pause()
        {
            Console.WriteLine("Телевізор призупинено.");
        }
    }
    class Radio: IPult
    {
        public void Vkl()
        {
            Console.WriteLine("Радіо увімкнено.");
        }
        public void Vukl()
        {
            Console.WriteLine("Радіо вимкнено.");
        }
        public void Pause()
        {
            Console.WriteLine("Радіо призупинено.");
        }
    }
    class Tel : IPult
    {
        public void Vkl()
        {
            Console.WriteLine("Телефон увімкнено.");
        }
        public void Vukl()
        {
            Console.WriteLine("Телефон вимкнено.");
        }
        public void Pause()
        {
            Console.WriteLine("Телефон призупинено.");
        }
    }
    class Comp : IPult
    {
        public void Vkl()
        {
            Console.WriteLine("Комп'ютер увімкнено.");
        }
        public void Vukl()
        {
            Console.WriteLine("Комп'ютер вимкнено.");
        }
        public void Pause()
        {
            Console.WriteLine("Комп'ютер призупинено.");
        }
    }
    class BIKS
    {
        public string Name;
        public int Age;
        public BIKS(string name, int age)
        {
            Name = name;
            Age = age;
        }
        static public void Avegare(BIKS[] stud)
        {
            int SR = 0;
            BIKS temp;
            BIKS[] Mass = new BIKS[stud.Length];
            for (int i = 0; i < stud.Length; i++)
            {
                SR += stud[i].Age;
            }
            SR = SR / stud.Length;
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i].Age -= SR;
            }
            for (int j = 0; j < stud.Length; j++)
            {
                for (int i = 0; i < stud.Length - 1; i++)
                {
                    if (Math.Abs(stud[i].Age) > Math.Abs(stud[i + 1].Age))
                    {
                        temp = stud[i];
                        stud[i] = stud[i + 1];
                        stud[i + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i].Age += SR;
            }
            Console.WriteLine($"Середній вік студентів в групі - {stud[0].Age}"); 
        }
    }
    class YIB
    {
        public string Name;
        public int Age;
        public YIB(string name, int age)
        {
            Name = name;
            Age = age;
        }
        static public void Avegare(YIB[] stud)
        {
            int SR = 0;
            YIB temp;
            YIB[] Mass = new YIB[stud.Length];
            for (int i = 0; i < stud.Length; i++)
            {
                SR += stud[i].Age;
            }
            SR = SR / stud.Length;
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i].Age -= SR;
            }
            for (int j = 0; j < stud.Length; j++)
            {
                for (int i = 0; i < stud.Length - 1; i++)
                {
                    if (Math.Abs(stud[i].Age) > Math.Abs(stud[i + 1].Age))
                    {
                        temp = stud[i];
                        stud[i] = stud[i + 1];
                        stud[i + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < stud.Length; i++)
            {
                stud[i].Age += SR;
            }
            Console.WriteLine($"Середній вік студентів в групі - {stud[0].Age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            TV tv = new TV();
            Radio radio = new Radio();
            Tel tel = new Tel();
            Comp comp = new Comp();
            tv.Vkl();
            radio.Vkl();
            tel.Vkl();
            comp.Vkl();
            Console.WriteLine();
            tv.Pause();
            radio.Pause();
            tel.Pause();
            comp.Pause();
            Console.WriteLine();
            tv.Vukl();
            radio.Vukl();
            tel.Vukl();
            comp.Vukl();
            Console.WriteLine("\n\n");
            BIKS[] Students = { new BIKS("Oleg", 19), new BIKS("Vlad", 21), new BIKS("Maria", 18), new BIKS("Sofia", 19), new BIKS("Dasha", 20) };
            YIB[] students = { new YIB("Oleg", 18), new YIB("Vlad", 19), new YIB("Maria", 18), new YIB("Sofia", 18), new YIB("Dasha", 17) };
            BIKS.Avegare(Students);
            YIB.Avegare(students);
        }
    }
}