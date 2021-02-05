using System;

namespace VezbanjeNaCas
{
    public class ClockTime : IClockTime
    {
        public string timeConversion(string theTimeString)
        {
            DateTime time = DateTime.Parse(theTimeString);
            if (theTimeString.ToLower().Contains("am") || theTimeString.ToLower().Contains("pm"))
            {
                Console.WriteLine("You have entered a time which is a 12-hour format");
                Console.WriteLine("Formated in 24-hour format:");
                return time.ToString("HH:mm");
            }
            else
            {
                Console.WriteLine("You have entered a time which is a 24-hour format");
                Console.WriteLine("Formated in 12-hour format:");
                return time.ToString("h:mm tt");
            }
        }
    }
}
