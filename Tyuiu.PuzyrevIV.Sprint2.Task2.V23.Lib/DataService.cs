using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.PuzyrevIV.Sprint2.Task2.V23.Lib
{
    public class DataService : ISprint2Task2V23
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            
            if ((x >= 3)  && (x <= 13) && (y >= 3) && (y <= 13))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }   
    }
}
