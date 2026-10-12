using Tyuiu.BliznetsVG.Sprint1.Task5.V4.Lib;
namespace Tyuiu.BliznetsVG.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();
            // Пример из эксайз к = 13257 ш = 3
            int time = 13257;
            int expected = 3;
            int actual = ds.SecondsToHours(time);

            Assert.AreEqual(expected, actual);
        }
    }
}
