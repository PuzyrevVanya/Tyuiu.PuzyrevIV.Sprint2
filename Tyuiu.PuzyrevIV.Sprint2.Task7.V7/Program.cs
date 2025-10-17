using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PuzyrevIV.Sprint2.Task7.V7.Lib;

namespace Tyuiu.PuzyrevIV.Sprint2.Task7.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Тема: Sprint #2. Добавление к решению итоговых проектов по спринту.     *");
            Console.WriteLine("* Задание #7. Вариант #7.                                                 *");
            Console.WriteLine("* Выполнил: Пузырев И.В. | CМАРТБ 25-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает координаты X,Y                  *");
            Console.WriteLine("* и вычисляет, находится ли точка в заштрихованной области.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.Write("Введите координату X (вещественное значение): ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка ввода! Введите корректное вещественное число для X.");
                Console.Write("Введите координату X: ");
            }

            Console.Write("Введите координату Y (вещественное значение): ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ошибка ввода! Введите корректное вещественное число для Y.");
                Console.Write("Введите координату Y: ");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            bool isInArea = ds.CheckPointInArea(x, y);

            if (isInArea)
            {
                Console.WriteLine($"Точка ({x}, {y}) НАХОДИТСЯ в заштрихованной области.");
            }
            else
            {
                Console.WriteLine($"Точка ({x}, {y}) НЕ НАХОДИТСЯ в заштрихованной области.");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Для завершения работы программы нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}