using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BliznetsVG.Sprint1.Task0.V2.Lib;

namespace Tyuiu.BliznetsVG.Sprint1.Task0.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new();
            Console.Title = "Спринт #1 | Выполнил: Близнец В. Г. | СМАРТб-26-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                        *");
            Console.WriteLine("* Задание #0                                              *");
            Console.WriteLine("* Вариант #2                                              *");
            Console.WriteLine("* Выполнил: Близнец Владислав Георгиевич | СМАРТб-26-1    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение         *");
            Console.WriteLine("* 3/3*2+12/4/3-2 и печатает результат на экране.          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* 3/3*2+12/4/3-2                                          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
