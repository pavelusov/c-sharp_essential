using System;
namespace lesson05_Indexers
{
    interface IWeek
    {
        string[] GetDays();
    }
    public class Week : IWeek
    {
		protected string[] days= {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"
            };
		public string this[int index]
        {
            get
            {
                if (index > 0 && index <= days.Length + 1) {
                    return days[index - 1];
                } else {
                    return "Enter 1-7";
                }
            }
        }
        public string[] GetDays()
        {
            return this.days;
        }
    }
    public class WeekEn : Week
    {
        private string[] values = {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };
        // Overload indexers
        public string this[string key]
        {
            get 
            {
                int indexDay = Array.IndexOf(days, key);
                string templateTranslation = $"{days[indexDay]} - {values[indexDay]}";
                string message = "This is not the day of the week";
                return !(indexDay < 0) ? templateTranslation : message;
            }
        }
    }
}
