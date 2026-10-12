using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BliznetsVG.Sprint1.Task3.V15.Lib
{
    public class DataService : ISprint1Task3V15
    {
        public double DistanceOverTime(double v1, double v2, double S, double T)
        {
            //Автомобили движутся в противоположные стороны
            //Расстояния растет со скоростью (в1 + в1)
            double result = S + (v1 + v2) * T;

            //Округляем колобок до 3 знаков после запиятой 
            return Math.Round(result, 3);
        }
    }
}
