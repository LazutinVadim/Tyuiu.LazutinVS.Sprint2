using Tyuiu.LazutinVS.Sprint2.Task3.V3.Lib;
namespace Tyuiu.LazutinVS.Sprint2.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}
