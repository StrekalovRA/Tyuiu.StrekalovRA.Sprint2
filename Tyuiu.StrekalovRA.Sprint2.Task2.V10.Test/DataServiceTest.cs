using Tyuiu.StrekalovRA.Sprint2.Task2.V10.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            Assert.AreEqual(DS.CheckDotInShadedArea(10, 10), false);
        }
    }
}