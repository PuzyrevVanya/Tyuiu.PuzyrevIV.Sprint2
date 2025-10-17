using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PuzyrevIV.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int year, int month, int day)
        {
            if (year <= 0 || month < 1 || month > 12 || day < 1 || day > 31)
            {
                return "Некорректная дата";
            }

            bool isLeapYear = DateTime.IsLeapYear(year);

            int[] daysInMonth = { 31, isLeapYear ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            day--;

            if (day < 1)
            {
                month--;

                if (month < 1)
                {
                    month = 12;
                    year--;

                    if (year <= 0)
                    {
                        return "Некорректная дата";
                    }

                    isLeapYear = DateTime.IsLeapYear(year);
                    daysInMonth[1] = isLeapYear ? 29 : 28;
                }

                day = daysInMonth[month - 1];
            }

            return $"{year}-{month:D2}-{day:D2}";
        }
    }
}
