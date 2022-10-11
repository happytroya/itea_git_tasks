using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class GetDate
    {
        DateTime date;
        DateTime userDate;
        DateTime defaultDate;


        bool isLeapYear;
        int i=0;
        
        public int I
        {
            get { return i; }
            set { i = value; }
        }




        public GetDate(DateTime userDate)
        {
            this.userDate = userDate;
        }

        public GetDate(DateTime defaultDate, DateTime userDate)
        {
            this.defaultDate = defaultDate;
            this.userDate = userDate;
            isLeapYear = (userDate.Year % 4 == 0) ? true : false;
        }

        public DateTime DefaultDate
        {
            get { return defaultDate; }
        }

        public DateTime UserDate
        {
            get { return userDate; }
            set { userDate = value; }
        }

        public DateTime this[int i] 
        {

            get { return UserDate + TimeSpan.FromDays(i); }
        }

        public override string ToString()
        {
            return UserDate.ToString();
        }

        public string ToString(bool dateOnly)
        {
                return Convert.ToString(DateOnly.FromDateTime(UserDate));
        }

        public DateTime TodaysDay()
        {
            date = DateTime.Now;
            return date;
        }

        public DateTime NextDay()
        {
            return UserDate.AddDays(+1);
        }

        public DateTime PreviousDay()
        {      
            return UserDate.AddDays(-1);
        }

        public int DaysLeftInMonth()
        {
            date = UserDate;
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }

        public void ShowDate()
        {
            Console.WriteLine("\nDefault date is :" + defaultDate);
            Console.WriteLine("\nUser date is: " + UserDate);
            Console.WriteLine("\nNext day is: " + NextDay());
            Console.WriteLine("\nPrevious day is: " + PreviousDay());
            Console.WriteLine("\nIs it leap year? = " + isLeapYear);
            Console.WriteLine("\nDays left in month: " + DaysLeftInMonth());
            Console.WriteLine("\nTodays is: " + TodaysDay());
        }
    }
}
