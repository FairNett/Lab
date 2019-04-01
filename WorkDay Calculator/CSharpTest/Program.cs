using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Start date:");
                DateTime Date = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Duration:");
                uint Duration = UInt32.Parse(Console.ReadLine());
                Console.Write("Weekends 1:");
                string[] Weekends = Console.ReadLine().Split('-');
                DateTime startWeek = Convert.ToDateTime(Weekends[0]);
                DateTime endtWeek = Convert.ToDateTime(Weekends[1]);
                WeekEnd[] weekEnd = new WeekEnd[]
                {
                new WeekEnd(startWeek, endtWeek)
                };
                Console.Write("Weekends 2:");
                string weekends = Console.ReadLine();
                if (weekends != "0")
                {
                    Weekends = weekends.Split('-');
                }
                startWeek = Convert.ToDateTime(Weekends[0]);
                endtWeek = Convert.ToDateTime(Weekends[1]);
                Array.Resize(ref weekEnd, 1);
                weekEnd[1] = new WeekEnd(startWeek, endtWeek);
                WorkDayCalculator calculator = new WorkDayCalculator();
                Console.WriteLine($"At the exit there should be: {calculator.Calculate(Date, Duration, weekEnd).ToShortDateString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
