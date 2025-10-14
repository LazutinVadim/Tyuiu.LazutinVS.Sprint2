using Tyuiu.LazutinVS.Sprint2.Task4.V28.Lib;
namespace Tyuiu.LazutinVS.Sprint2.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 6;
            var res = ds.Calculate(x, y);
            var wait = 9;
            Assert.AreEqual(res, wait);
        }
    }
}
