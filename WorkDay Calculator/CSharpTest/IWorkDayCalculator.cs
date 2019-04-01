using System;

namespace CSharpTest
{
    public interface IWorkDayCalculator
    {
        DateTime Calculate(DateTime startDate, uint dayCount, WeekEnd[] weekEnds);
    }
}
