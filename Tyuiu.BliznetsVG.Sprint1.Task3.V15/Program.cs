using System;
using Tyuiu.BliznetsVG.Sprint1.Task3.V15.Lib;

namespace Tyuiu.BliznetsVG.Sprint1.Task3.V15;

    class Program
    {
        static void Main(string[] args)
        {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Близнец В. Г. | СМАРТб-26-1";
        Console.WriteLine("***********************************************************");
        Console.WriteLine("* Спринт #1                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                        *");
        Console.WriteLine("* Задание #3                                              *");
        Console.WriteLine("* Вариант #15                                             *");
        Console.WriteLine("* Выполнил: Близнец Владислав Георгиевич | СМАРТб-26-1    *");
        Console.WriteLine("***********************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя  *");
        Console.WriteLine("* исходные данные, выполняет указанные расчёты и печатает *");
        Console.WriteLine("* результат на экране.                                    *");
        Console.WriteLine("*                                                         *");
        Console.WriteLine("* Формулировка задания:                                   *");
        Console.WriteLine("* Два автомобиля имеют скорости V1 км/ч и V2 км/ч          *");
        Console.WriteLine("* соответственно, находятся на расстоянии S км друг от    *");
        Console.WriteLine("* друга и движутся в противоположные стороны. Определить  *");
        Console.WriteLine("* расстояние между ними через T часов. Ответ округлить    *");
        Console.WriteLine("* до 3 знаков после запятой.                              *");
        Console.WriteLine("*                                                         *");
        Console.WriteLine("* Что пользователь вводит?                                *");
        Console.WriteLine("* V1, V2 (км/ч), S (км), T (ч)                            *");
        Console.WriteLine("* Что программа печатает на экране?                       *");
        Console.WriteLine("* Расстояние между автомобилями (вещественное число)      *");
        Console.WriteLine("***********************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
        Console.WriteLine("***********************************************************");

        Console.WriteLine("Введите скорость первого автомобиля V1 (км/ч):");
        double v1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите скорость второго автомобиля V2 (км/ч):");
        double v2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите начальное расстояние S (км):");
        double s = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите время T (ч):");
        double t = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***********************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
        Console.WriteLine("***********************************************************");

        double result = ds.DistanceOverTime(v1, v2, s, t);
        Console.WriteLine("Расстояние между автомобилями = " + result + " км");

        Console.ReadLine();
    }
    }


