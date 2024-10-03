using Tyuiu.StrekalovRA.Sprint2.Task3.V9.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            Assert.AreEqual(DS.Calculate(0), 1);
        }
    }
}