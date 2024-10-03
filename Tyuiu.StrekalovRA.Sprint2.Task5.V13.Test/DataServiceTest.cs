using Tyuiu.StrekalovRA.Sprint2.Task5.V13.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DS = new DataService();
        [TestMethod] public void TestMethod1() { Assert.AreEqual(DS.FindDateOfNextDay(0, 10, 9), "10/10/0"); }
        [TestMethod] public void TestMethod2() { Assert.AreEqual(DS.FindDateOfNextDay(0, 12, 19), "20/12/0"); }
        [TestMethod] public void TestMethod3() { Assert.AreEqual(DS.FindDateOfNextDay(0, 12, 31), "1/1/1"); }
        [TestMethod] public void TestMethod4() { Assert.AreEqual(DS.FindDateOfNextDay(0, 10, 31), "1/11/0"); }
        [TestMethod] public void TestMethod5() { Assert.AreEqual(DS.FindDateOfNextDay(1, 12, 0), "1/12/1"); }
        [TestMethod] public void TestMethod6() { Assert.AreEqual(DS.FindDateOfNextDay(0, 1, 31), "1/2/0"); }
    }
}