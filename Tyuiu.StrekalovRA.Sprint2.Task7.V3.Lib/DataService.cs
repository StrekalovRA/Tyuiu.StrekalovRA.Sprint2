using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StrekalovRA.Sprint2.Task7.V3.Lib
{
    public class DataService : ISprint2Task7V3
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool Apper_Area = ((Math.Pow(x, 2) + Math.Pow(y - 1, 2)) <= 1);
            bool Lower_Area = (y <= (1 - Math.Pow(x, 2)));
            return (Apper_Area && Lower_Area);
        }
    }
}
