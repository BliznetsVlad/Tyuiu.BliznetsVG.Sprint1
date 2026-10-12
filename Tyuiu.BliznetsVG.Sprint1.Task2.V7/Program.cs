using Tyuiu.BliznetsVG.Sprint1.Task2.V7.Lib;

//Написать программу, которая запрашивает у пользователя исходные данные, выполняет указанные расчёты и печатает результат на экране.
//Формулировка задания: Известен радиус круга.Вычислить примерную площадь круга. Ответ округлите до 3 знаков после запятой.
//Что пользователь вводит? Радиус круга (целое число)
//Что программа печатает на экране? Площадь круга (вещественное число)

namespace Tyuiu.BliznetsVG.Sprint1.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Близнец В. Г. | СМАРТб-26-1";
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* Спринт #1                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                        *");
            Console.WriteLine("* Задание #2                                              *");
            Console.WriteLine("* Вариант #7                                              *");
            Console.WriteLine("* Выполнил: Близнец Владислав Георгиевич | СМАРТб-26-1    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя  *");
            Console.WriteLine("* исходные данные, выполняет указанные расчёты и печатает *");
            Console.WriteLine("* результат на экране.                                    *");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("* Формулировка задания: Известен радиус круга. Вычислить  *");
            Console.WriteLine("* примерную площадь круга. Ответ округлить до 3 знаков    *");
            Console.WriteLine("* после запятой.                                          *");
            Console.WriteLine("*                                                         *");
            Console.WriteLine("* Что пользователь вводит? Радиус круга (целое число)     *");
            Console.WriteLine("* Что программа печатает на экране? Площадь круга         *");
            Console.WriteLine("* (вещественное число)                                    *");
            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите радиус круга (целое число):");
            int radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            double result = ds.CalculateSquareCircle(radius);
            Console.WriteLine("Площадь круга = " + result);

            Console.ReadLine();
        }
    }
}