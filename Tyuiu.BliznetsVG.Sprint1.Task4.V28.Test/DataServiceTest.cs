using Tyuiu.BliznetsVG.Sprint1.Task4.V28.Lib;
namespace Tyuiu.BliznetsVG.Sprint1.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            //ПРИМЕРРРРР х 1 у 2
            // кос(60*пи/2) = кос(30*пи) = 1
            //ехп (2*1+2) = ехп(4) = 54.598
            //результ = 1/54.598 = 0.018
            double x = 1;
            double y = 2;

            double expected = 0.018;
            double actual = ds.Calculate(x, y);

            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
