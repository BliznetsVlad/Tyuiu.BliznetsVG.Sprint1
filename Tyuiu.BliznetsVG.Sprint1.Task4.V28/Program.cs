using System;
using Tyuiu.BliznetsVG.Sprint1.Task4.V28.Lib;

namespace Tyuiu.BliznetsVG.Sprint1.Task4.V28;
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Близнец В. Г. | СМАРТб-26-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                        *");
            Console.WriteLine("* Задание #4                                              *");
            Console.WriteLine("* Вариант #28                                             *");
            Console.WriteLine("* Выполнил: Близнец Владислав Георгиевич | СМАРТб-26-1    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя  *");
            Console.WriteLine("* исходные данные, вычисляет результат по формуле и       *");
            Console.WriteLine("* печатает его на экране. Ответ округлить до 3 знаков     *");
            Console.WriteLine("* после запятой.                                          *");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("* Формула: cos(60 * pi / 2) / Exp(2 * x + y)              *");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("* Что пользователь вводит? x, y                           *");
            Console.WriteLine("* Что программа печатает на экране? Результат вычисления  *");
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

            double result = ds.Calculate(x, y);
            Console.WriteLine("Результат = " + result);

            Console.ReadLine();
        }
    }