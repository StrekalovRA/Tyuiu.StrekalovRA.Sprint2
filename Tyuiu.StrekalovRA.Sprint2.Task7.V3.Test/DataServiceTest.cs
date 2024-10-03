using Tyuiu.StrekalovRA.Sprint2.Task7.V3.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DS = new DataService();
        [TestMethod] public void TestMethod1() { Assert.AreEqual(DS.CheckDotInShadedArea(-0.1, -0.3), false); }
        [TestMethod] public void TestMethod2() { Assert.AreEqual(DS.CheckDotInShadedArea(0, 0), true); }
        [TestMethod] public void TestMethod3() { Assert.AreEqual(DS.CheckDotInShadedArea(0.5, 0.4), true); }
        [TestMethod] public void TestMethod4() { Assert.AreEqual(DS.CheckDotInShadedArea(1.0, 0), false); }
    }
}