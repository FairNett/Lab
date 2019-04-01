using System;

namespace ConsoleApp5
{
    class Program
    {
        class Student
        {
            private string Name;
            private int Kypc;
            private bool Stipendia;
            public Student()
            {
                Name = "Oleg";
                Kypc = 4;
                Stipendia = true;
            }
            public Student(string name, int kypc)
            {
                Name = name;
                Kypc = kypc;
                Stipendia = false;
            }
            public Student(string name, bool stipuxa)
            {
                Name = name;
                Kypc = 1;
                Stipendia = stipuxa;
            }
            public Student(string name, int kypc, bool stipuxa)
            {
                Name = name;
                Kypc = kypc;
                Stipendia = stipuxa;
            }
            public void Display_info()
            {
                Console.WriteLine($"Ім'я: {Name}\nКурс: {Kypc}\nНаявність стипендії: {Stipendia}\n");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Student Oleg = new Student();
            Student Dimon = new Student("Dimon", 3);
            Student Sveta = new Student("Sveta", false);
            Student Olga = new Student("Olga", 2, true);
            Oleg.Display_info();
            Dimon.Display_info();
            Sveta.Display_info();
            Olga.Display_info();
        }
    }
}
