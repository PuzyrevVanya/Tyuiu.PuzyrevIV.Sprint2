using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PuzyrevIV.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (g <= 0 || m < 1 || m > 12 || n < 1 || n > 31)
            {
                return "Некорректная дата"; 
            }

            int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


            n++;

            if (n > daysInMonth[m - 1])
            {
                n = 1; 
                m++;    

                if (m > 12)
                {
                    m = 1;  
                    g++;   
                }
            }
           
            return $"{g}-{m:D2}-{n:D2 }";
        }
    }
}
