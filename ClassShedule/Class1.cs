using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassShedule
{
    public class Class1
    {
        Dictionary<DateTime, List<(TimeSpan StartTime, TimeSpan Duration, string EventName)>> schedule = new Dictionary<DateTime, List<(TimeSpan, TimeSpan, string)>>();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="start"></param>
        /// <param name="duration"></param>
        /// <param name="name"></param>
        public void AddEvent(DateTime date, TimeSpan start,TimeSpan duration, string name)
        {
            DateTime date1 = date;
            schedule[date1] = new List<(TimeSpan, TimeSpan, string)>
                {
                    (start, duration, name),
                };
            foreach (var item in schedule.Keys)
            {
                Console.WriteLine(item);
            }
            foreach (KeyValuePair<DateTime, List<(TimeSpan StartTime, TimeSpan Duration, string EventName)>> entry in schedule)
            {
                Console.WriteLine("Дата: " + entry.Key);
                foreach (var item in  entry.Value)
                {
                    Console.WriteLine(item.StartTime);
                    Console.WriteLine(item.Duration);
                    Console.WriteLine(item.EventName);
                    
                }
            }
        }
        public void ReplaceStartTime(DateTime date,TimeSpan startTimeDefault,TimeSpan startTimeChanged)
        {
            if (schedule.Keys.Contains(date) && schedule[date].Contains(startTimeDefault))
            {
                var resultDate = schedule.Keys.FirstOrDefault(x => x == date);
                var result = schedule[resultDate].ToList().FirstOrDefault(x => x.StartTime == startTimeDefault);

                result.StartTime = startTimeChanged;
            }
        }

        public void ReplaceDuration(DateTime date, TimeSpan durationDefault,TimeSpan durationChanged)
        {
            if (schedule.Keys.Contains(date))
            {
                var resultDate = schedule.Keys.FirstOrDefault(x => x == date);
                var result = schedule[resultDate].ToList().FirstOrDefault(x => x.Duration == durationDefault);

                result.StartTime = durationChanged;
            }
        }

        public void ReplaceName(DateTime date, string nameDafeult,string nameChanged)
        {
            if (schedule.Keys.Contains(date))
            {
                var resultDate = schedule.Keys.FirstOrDefault(x => x == date);
                var result = schedule[resultDate].ToList().FirstOrDefault(x => x.EventName == nameDafeult);

                result.EventName = nameChanged;
            }
        }

        public void FindEvent()
        {

        }
    }
}
