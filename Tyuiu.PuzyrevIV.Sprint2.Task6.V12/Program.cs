using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint2.Task6.V12.Lib;

namespace Tyuiu.PuzyrevIV.Sprint2.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*********************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                          *");
            Console.WriteLine("*********************************************");

            int year, month, day;

            Console.WriteLine("Введите год: ");
            while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
            {
                Console.WriteLine("Некорректный ввод. Введите год (целое положительное число): ");
            }

            Console.WriteLine("Введите номер месяца (от 1 до 12): ");
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.WriteLine("Некорректный ввод. Введите номер месяца (от 1 до 12): ");
            }

            Console.WriteLine("Введите число (от 1 до 31): ");
            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
            {
                Console.WriteLine("Некорректный ввод. Введите число (от 1 до 31): ");
            }

            string previousDay = ds.FindDateOfPreviousDay(year, month, day);

            Console.WriteLine("*********************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                *");
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Дата предыдущего дня: {previousDay}");

            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}