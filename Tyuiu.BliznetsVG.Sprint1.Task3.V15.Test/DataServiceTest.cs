using Tyuiu.BliznetsVG.Sprint1.Task3.V15.Lib;
namespace Tyuiu.BliznetsVG.Sprint1.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            //Для примера я возьму: В1=60, В2=80, С=100, Тайм=2
            //С между в1в2 = 100 + ( 60 + 80 ) * 2 = 100 + 140 * 2 = 100 +280 = 380 ыыы
            double v1 = 60;
            double v2 = 80;
            double S = 100;
            double T = 2;

            double expected = 380;
            double actual = ds.DistanceOverTime(v1, v2, S, T);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
