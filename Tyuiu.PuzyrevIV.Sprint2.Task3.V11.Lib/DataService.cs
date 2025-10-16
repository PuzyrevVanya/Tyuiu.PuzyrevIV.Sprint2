using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PuzyrevIV.Sprint2.Task3.V11.Lib
{
    public class DataService : ISprint2Task3V11
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = x + Math.Pow((x - 15.0) / (x - 19.0), x);
            }
            else
            {
                if (y == 0)
                {
                    y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10.0) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 12.0);
                }
                else
                {
                    if ((x > -15) && (x < 0))
                    {
                        y = Math.Pow((1.0 + (1.0 / Math.Pow(x, 2))), x);
                    }
                    else
                    {
                        if (x < -15)
                        {
                            y = x + 10.0 * x - (1.0 / x);
                        }
                    }
                }
            }
            return Math.Round(y, 3);
        }
    }
}
