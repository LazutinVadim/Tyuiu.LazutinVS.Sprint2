using Tyuiu.LazutinVS.Sprint2.Task5.V12.Lib;
namespace Tyuiu.LazutinVS.Sprint2.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var ds = new DataService(); 
            Assert.AreEqual("16.10.2024", ds.FindDateOfPreviousDay(2024, 10, 17));
        }
    }
}
