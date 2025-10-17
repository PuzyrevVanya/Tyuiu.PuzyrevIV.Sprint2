using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PuzyrevIV.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool condition1 = y >= x;
            bool condition2 = y <= (2 - x * x);
            bool condition3 = x <= 0;

            return condition1 && condition2 && condition3;
        }
    }
}
