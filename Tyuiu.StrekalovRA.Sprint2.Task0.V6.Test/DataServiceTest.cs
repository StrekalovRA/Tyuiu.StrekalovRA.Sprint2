using Tyuiu.StrekalovRA.Sprint2.Task0.V6.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool[] A = new bool[] { true, true, true, false, true, false };
            DataService DS = new DataService();
            CollectionAssert.AreEqual(DS.GetCompareOperations(107, 754), A);
        }
    }
}