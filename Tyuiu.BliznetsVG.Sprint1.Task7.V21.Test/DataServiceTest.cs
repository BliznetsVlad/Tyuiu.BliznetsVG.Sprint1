using Tyuiu.BliznetsVG.Sprint1.Task7.V21.Lib;
namespace Tyuiu.BliznetsVG.Sprint1.Task7.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            // Возьмём x = 1, y = 2 (знаменатели не нулевые)
            double x = 1;
            double y = 2;

            // Посчитаем эталон вручную:
            // Math.Pow(2, 1) = 2
            // Math.Cos(1) = 0.5403, x/3 = 0.3333 → знаменатель 1 = 0.2070
            // первое слагаемое = 2 / 0.2070 = 9.662
            //
            // Math.Sin(1*1) = Math.Sin(1) = 0.8415
            // Math.Cos(2) = -0.4161 → числитель 2 = 0.4254
            // Math.Sin(2) = 0.9093 → знаменатель 2 = 0.5403 - 0.9093 = -0.3690
            // Math.Tan(1*2) = Math.Tan(2) = -2.185
            // второе слагаемое = (0.4254 / -0.3690) * (-2.185) = 2.519
            //
            // z = 9.662 + 2.519 = 12.182
            double expected = 12.182;
            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual,0.001);

        }
    }
}
