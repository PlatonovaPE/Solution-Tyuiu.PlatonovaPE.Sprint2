using Tyuiu.PlatonovaPE.Sprint2.Task2.V28.Lib;
namespace Tyuiu.PlatonovaPE.Sprint2.Task2.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 3;
            int y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}