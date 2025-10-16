using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint2.Task4.V27.Lib;

namespace Tyuiu.PuzyrevIV.Sprint2.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("*******************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                        *");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Введите значения переменой X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значения переменой Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("*******************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                              *");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}
