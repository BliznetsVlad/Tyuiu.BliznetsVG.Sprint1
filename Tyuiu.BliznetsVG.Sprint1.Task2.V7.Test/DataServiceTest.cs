using Tyuiu.BliznetsVG.Sprint1.Task2.V7.Lib;
namespace Tyuiu.BliznetsVG.Sprint1.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int radius = 2;
            double expected = 12.566; // π * 4 ≈ 12.566

            double actual = ds.CalculateSquareCircle(radius);
            Assert.AreEqual(expected, actual, 0.001);

        }
    }
}
