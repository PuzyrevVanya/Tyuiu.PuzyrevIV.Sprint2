using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PuzyrevIV.Sprint2.Task4.V27.Lib
{
    public class DataService : ISprint2Task4V27
    {
        public double Calculate(double x, double y)
        {
            double z = x - 10 > y + 2 ? (x * Math.Pow((y + 2) / (x - 1), x)) : (Math.Pow(y, 2) - Math.Pow(2.0 / x, 2));
            return Math.Round(z, 3);            
        }
    }
}
