using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint2.Task2.V23.Lib;

namespace Tyuiu.PuzyrevIV.Sprint2.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                        *");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Введите значения переменой X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значения переменой Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            DataService ds = new DataService();
            bool res = ds.CheckDotInShadedArea(x, y);

            Console.WriteLine("*******************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                              *");
            Console.WriteLine("*******************************************");
            if (res)
            {
                Console.WriteLine("Точка находится в заштриховоной области");
            }                
            else
            {
                Console.WriteLine("Точка не находится в заштриховоной области");
            }
            Console.ReadKey();
        }
    }
}
