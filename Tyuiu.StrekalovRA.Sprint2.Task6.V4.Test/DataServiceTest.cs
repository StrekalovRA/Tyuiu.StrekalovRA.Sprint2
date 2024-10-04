using Tyuiu.StrekalovRA.Sprint2.Task6.V4.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService DS = new DataService();
        [TestMethod] public void TestMethod1() { Assert.AreEqual(DS.FindCardSuit(4), "червы"); }
        [TestMethod] public void TestMethod2() { Assert.AreEqual(DS.FindCardSuit(-10), "-"); }
    }
}