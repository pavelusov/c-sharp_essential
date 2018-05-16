using System;

namespace lesson05_Indexers
{
    class MainClass
    {
        public static void Main(string[] args)
        {

			WeekEn weekEnglish = new WeekEn();

            foreach (string day in weekEnglish.GetDays())
            {
                System.Console.WriteLine(weekEnglish[day]);
            }
        }
    }
}
