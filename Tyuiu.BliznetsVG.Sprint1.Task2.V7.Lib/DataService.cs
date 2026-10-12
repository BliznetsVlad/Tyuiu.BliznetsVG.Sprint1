using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BliznetsVG.Sprint1.Task2.V7.Lib
{
    public class DataService : ISprint1Task2V7
    {
        public double CalculateSquareCircle(int value)
        {
            double result = Math.PI * value * value;
            return Math.Round(result, 3);
        }
            
    }
}
