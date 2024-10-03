using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StrekalovRA.Sprint2.Task1.V18.Lib
{
    public class DataService : ISprint2Task1V18
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        { // 155, 696, 242, 541
            bool[] result = new bool[] { 
                (a > b) || (a < c), (b>=c) && (!(c > d)), !(a>=d),
                (a < c)&&(c > d),(b<c)||(a<=d), (!(a>=b))&&(!(b>=c))
            };
            return result;
        }
    }
}
