using System;
using Tyuiu.BliznetsVG.Sprint1.Task6.V15.Lib;

namespace Tyuiu.BliznetsVG.Sprint1.Task6.V15;

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
            Console.WriteLine("* Вариант #15                                             *");
            Console.WriteLine("* Выполнил: Близнец Владислав Георгиевич | СМАРТб-26-1    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.          *");
            Console.WriteLine("* Проверить, что в строке больше букв, чем знаков.        *");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("* Что пользователь вводит? Текст (строку)                 *");
            Console.WriteLine("* Что программа печатает на экране? Результат проверки    *");
            Console.WriteLine("* (true / false)                                          *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите текст:");
            string value = Console.ReadLine();

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            bool result = ds.CheckLettersCount(value);
            Console.WriteLine("Букв больше, чем знаков: " + result);

            Console.ReadLine();
        }
    }