//This is a C# program that switches the number of the day with the name of the day in the week
using System;

namespace Cases.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetDay(2));
        }
        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break; //We insert "break" to stop the program once it has switched 
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName; //Returns the day Name requested
        }
    }
}