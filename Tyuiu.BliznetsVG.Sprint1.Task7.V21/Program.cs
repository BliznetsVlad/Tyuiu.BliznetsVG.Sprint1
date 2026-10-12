using System;
using Tyuiu.BliznetsVG.Sprint1.Task7.V21.Lib;

namespace Tyuiu.BliznetsVG.Sprint1.Task7.V21;
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Близнец В. Г. | СМАРТб-26-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                        *");
            Console.WriteLine("* Задание #5                                              *");
            Console.WriteLine("* Вариант #21                                             *");
            Console.WriteLine("* Выполнил: Близнец Владислав Георгиевич | СМАРТб-26-1    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое    *");
            Console.WriteLine("* выражение по исходным значениям данных, вводимых        *");
            Console.WriteLine("* пользователем. Ответ округлить до 3 знаков после        *");
            Console.WriteLine("* запятой.                                                *");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("*         y^x          sin(x^2) + cos(y)                  *");
            Console.WriteLine("* z = ----------- + ------------------- * tg(x*y)         *");
            Console.WriteLine("*     cos(x) - x/3   cos(x) - sin(y)                      *");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("* Что пользователь вводит? x, y                           *");
            Console.WriteLine("* Что программа печатает на экране? z (вещественное)      *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите значение x:");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            double z = ds.Calculate(x, y);
            Console.WriteLine("z = " + z);

            Console.ReadLine();
        }
    }