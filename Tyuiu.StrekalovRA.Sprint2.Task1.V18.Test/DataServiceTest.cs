using Tyuiu.StrekalovRA.Sprint2.Task1.V18.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool[] A = new bool[] { true, true, true, false, true, false };
            DataService DS = new DataService();
            CollectionAssert.AreEqual(DS.GetLogicOperations(155, 696, 242, 541), A);
        }
    }
}