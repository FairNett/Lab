using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Default;
            List<string> CS21 =  new List<string>() { "Андрейчук Ольга", "Андрусяк Михайло", "Архипов Ярослав", "Блохіна Дар'я", "Галась Марія", "Гедеон Максим", "Гулаков Данило", "Євенко Владислав", "Жолнер Іван", "Золотарьов Кирило", "Качмала Олександра", "Ковальчук Павло", "Кольцов Даніл", "Купріна Лада", "Майборода Юлія", "Моклякова Катерина", "Мухайдлі Шаді-Олександр", "Рой Антон", "Сарока Світлана", "Скрипник Максим", "Тіщенко Катерина", "Фаль Лука", "Черняк Олександра", "Шалатонов Олег"};
            foreach (string student in CS21)
            {
                Console.WriteLine(student);
            }
            using (StreamWriter writer = new StreamWriter(@"D:\4 семестр\ТПЗІ\group.txt"))
            {
                writer.WriteLine($"--------------Кількість студентів у групі: {CS21.Count}--------------");
                CS21.Sort();
                foreach (string student in CS21)
                {
                    writer.WriteLine(student);
                }
                writer.WriteLine("--------------Останні 10 студентів--------------");
                for (int i = 14; i < CS21.Count; i++)
                {
                    writer.WriteLine(CS21[i]);
                }
            }
        }
    }
}
