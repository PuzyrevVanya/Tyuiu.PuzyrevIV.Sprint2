using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint2.Task5.V11.Lib;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.PuzyrevIV.Sprint2.Task5.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*******************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                        *");
            Console.WriteLine("*******************************************");

            Console.WriteLine("Введите номер месяца: ");
            int g, m, n;

            Console.WriteLine("Введите год: ");
            while (!int.TryParse(Console.ReadLine(), out g) || g <= 0)
            {
                Console.WriteLine("Некорректный ввод. Введите год (целое положительное число): ");
            }

            Console.WriteLine("Введите номер месяца (от 1 до 12): ");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 1 || m > 12)
            {
                Console.WriteLine("Некорректный ввод. Введите номер месяца (от 1 до 12): ");
            }

            Console.WriteLine("Введите число (от 1 до 31): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 31)
            {
                Console.WriteLine("Некорректный ввод. Введите число (от 1 до 31): ");
            }

            string nextDay = ds.FindDateOfNextDay(g, m, n);

            Console.WriteLine("*********************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                *");
            Console.WriteLine("*********************************************");
            Console.WriteLine($"Дата следующего дня: {nextDay}");

            Console.WriteLine("Для завершения нажмите любую клавишу...");
            Console.ReadKey(); 
        }
    }
}
        }
    }
}
   
  