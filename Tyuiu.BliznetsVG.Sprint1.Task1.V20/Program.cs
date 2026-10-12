using System;
using Tyuiu.BliznetsVG.Sprint1.Task1.V20.Lib;

namespace Tyuiu.BliznetsVG.Sprint1.Task1.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт 1 | Выполнил: Близнец В.Г. | СМАРТб-26-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                        *");
            Console.WriteLine("* Задание #1                                              *");
            Console.WriteLine("* Вариант #20                                             *");
            Console.WriteLine("* Выполнил: Близнец Владислав Георгиевич | СМАРТб-26-1    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                 *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя   *");
            Console.WriteLine("*исходные данные, вычисляет результат по формуле          *");
            Console.WriteLine("*(x*y/2) + 10 и печатает его на экране.                   *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* (x*y/2) + 10                                            *");
            Console.WriteLine("***********************************************************");
            

            double x,y;

            Console.WriteLine("Введите значение х");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadLine();
        }
    }
}
