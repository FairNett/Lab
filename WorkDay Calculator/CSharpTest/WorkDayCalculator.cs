using System;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, uint dayCount, WeekEnd[] weekEnds)
        {
            for (int i = 0; i < weekEnds.Length-1; i++)
            {
                if (weekEnds[i].StartDate.Day> weekEnds[i+1].StartDate.Day)
                {
                    var temp = weekEnds[i];
                    weekEnds[i] = weekEnds[i + 1];
                    weekEnds[i + 1] = temp;
                }
            }
            if (startDate < weekEnds[0].StartDate)
            {
                dayCount--;
            }


            for (int i = 0; i < weekEnds.Length; i++)
            {
                while (dayCount != 0)
                {
                    if ((startDate.AddDays(1) < weekEnds[i].StartDate || startDate.AddDays(1) > weekEnds[i].EndDate) && (startDate.AddDays(1) < weekEnds[i + 1].StartDate || startDate.AddDays(1) > weekEnds[i + 1].EndDate))
                    {
                        startDate = startDate.AddDays(1);
                        dayCount--;
                    }
                    else 
                    {
                        startDate = startDate.AddDays(1);
                    }
                }
            }
            return startDate;
        }

            
        
    }
}
