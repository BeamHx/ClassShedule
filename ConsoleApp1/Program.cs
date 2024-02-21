using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<DateTime, List<(TimeSpan StartTime, TimeSpan Duration, string EventName)>> schedule = new Dictionary<DateTime, List<(TimeSpan, TimeSpan, string)>>();

            DateTime date1 = new DateTime(2024, 2, 7);
            schedule[date1] = new List<(TimeSpan, TimeSpan, string)>
                {
                    (new TimeSpan(9, 0, 0), new TimeSpan(1, 0, 0), "Встреча 1"),
                    (new TimeSpan(10, 30, 0), new TimeSpan(0, 45, 0), "Встреча 2")
                };

            DateTime date2 = new DateTime(2024, 2, 8);
            schedule[date2] = new List<(TimeSpan, TimeSpan, string)>
            {
                (new TimeSpan(12, 0, 0), new TimeSpan(2, 0, 0), "Встреча 3")
            };

            Console.WriteLine(schedule[date2][0].StartTime);

            schedule[date2][0] = new TimeSpan(0, 0, 0);

             
            List<TimeSpan> schedule2 = new List<TimeSpan>
            {
                new TimeSpan(0, 0, 0)
            };

            schedule2[0] = new TimeSpan(0, 0, 1);
        }
    }
}
