using Tyuiu.LazutinVS.Sprint2.Task2.V25.Lib;

namespace Tyuiu.LazutinVS.Sprint2.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 5;
            Assert.AreEqual(true, ds.CheckDotInShadedArea(x, y));
        }
    }
}
