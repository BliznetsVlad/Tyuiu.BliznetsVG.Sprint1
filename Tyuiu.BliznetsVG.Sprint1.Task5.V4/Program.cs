using System;
using Tyuiu.BliznetsVG.Sprint1.Task5.V4.Lib;

namespace Tyuiu.BliznetsVG.Sprint1.Task5.V4;
    
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #1 | Выполнил: Близнец В. Г. | СМАРТб-26-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                        *");
            Console.WriteLine("* Задание #1                                              *");
            Console.WriteLine("* Вариант #4                                              *");
            Console.WriteLine("* Выполнил: Близнец Владислав Георгиевич | СМАРТб-26-1    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:    *");
            Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных      *");
            Console.WriteLine("* часов (h) прошло к этому моменту.                       *");
            Console.WriteLine("* (например, h=3, если k=13257)                           *");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("* Что пользователь вводит? k (номер секунды суток)        *");
            Console.WriteLine("* Что программа печатает на экране? Количество полных     *");
            Console.WriteLine("* часов h                                                 *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите номер секунды суток time:");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            int h = ds.SecondsToHours(time);
            Console.WriteLine("Полных часов прошло: " + h);

            Console.ReadLine();
        }
    }