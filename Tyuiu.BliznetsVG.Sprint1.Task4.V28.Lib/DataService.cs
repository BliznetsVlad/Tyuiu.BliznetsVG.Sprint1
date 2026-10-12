using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BliznetsVG.Sprint1.Task4.V28.Lib
{
    public class DataService : ISprint1Task4V28
    {
        public double Calculate(double x, double y)
        {
            //Формулыыыыыы : cos(60*pi / 2) / Exp(2 * x + y)
            double numerator = Math.Cos(60 * Math.PI / 2);
            double denominator = Math.Exp(2 * x + y);

            double result = numerator / denominator;

            //Опять колобок до 3 после ,
            return Math.Round (result, 3);
        }
    }
}
