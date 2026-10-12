using Tyuiu.BliznetsVG.Sprint1.Task6.V15.Lib;
namespace Tyuiu.BliznetsVG.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            //"Я хочу, хоть раз в жизни, побыть один и почувствовать себя свободным человеком." буково - 60 знаков - 3
            // 60 > 3
            string value = "Я хочу, хоть раз в жизни, побыть один и почувствовать себя свободным человеком.";
            bool expected = true;
            bool actual = ds.CheckLettersCount(value);

            Assert.AreEqual(expected, actual);
        }
    }
}
