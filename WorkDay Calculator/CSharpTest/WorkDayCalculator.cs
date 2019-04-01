using System;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, uint dayCount, WeekEnd[] weekEnds)
        {
            for (int i = 0; i < weekEnds.Length-1; i++)
            {
                if (weekEnds[i].StartDate> weekEnds[i+1].StartDate)
                {
                    var temp = weekEnds[i];
                    weekEnds[i] = weekEnds[i + 1];
                    weekEnds[i + 1] = temp;
                }
            }
            if (startDate != weekEnds[0].StartDate)
            {
                dayCount--;
            }

            while (dayCount != 0)
            {
                for (int i = 0; i < weekEnds.Length-1; i++)
                {
                        if (startDate.AddDays(1) != weekEnds[i].StartDate)
                        {
                            startDate = startDate.AddDays(1);
                            dayCount--;
                        }
                        else
                        {
                            startDate = weekEnds[i].EndDate.AddDays(1);
                            dayCount--;
                        }
                }
            }

            return startDate;
        }
    }
}
