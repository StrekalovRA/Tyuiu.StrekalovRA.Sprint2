using Tyuiu.StrekalovRA.Sprint2.Task4.V8.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService DS = new DataService();
            Assert.AreEqual(DS.Calculate(1, 1), -6);
        }
    }
}