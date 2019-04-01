using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, uint dayCount, WeekEnd[] weekEnds)
        {
            for (int i = 0; i < weekEnds.Length-1; i++)
            {
                if (weekEnds[i].StartDate>)
                {

                }
            }
            if (startDate != weekEnds[0].StartDate)
            {
                dayCount--;
            }

            while (dayCount != 0)
            {
                for (int i = 0; i < weekEnds.Length; i++)
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
