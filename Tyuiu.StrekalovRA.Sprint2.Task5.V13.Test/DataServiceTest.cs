using Tyuiu.StrekalovRA.Sprint2.Task5.V13.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DS = new DataService();
        [TestMethod] public void TestMethod1() { Assert.AreEqual(DS.FindDateOfNextDay(2000, 10, 9), "10.10.2000"); }
        [TestMethod] public void TestMethod2() { Assert.AreEqual(DS.FindDateOfNextDay(2000, 12, 19), "20.12.2000"); }
        [TestMethod] public void TestMethod3() { Assert.AreEqual(DS.FindDateOfNextDay(2000, 12, 31), "01.01.2001"); }
        [TestMethod] public void TestMethod4() { Assert.AreEqual(DS.FindDateOfNextDay(2000, 10, 31), "01.11.2000"); }
        [TestMethod] public void TestMethod5() { Assert.AreEqual(DS.FindDateOfNextDay(2000, 12, 0), "01.12.2000"); }
        [TestMethod] public void TestMethod6() { Assert.AreEqual(DS.FindDateOfNextDay(2000, 1, 31), "01.02.2000"); }
    }
}