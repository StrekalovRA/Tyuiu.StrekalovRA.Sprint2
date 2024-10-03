using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StrekalovRA.Sprint2.Task4.V8.Lib
{
    public class DataService : ISprint2Task4V8
    {
        public double Calculate(double x, double y)
        {
            double Z;
            if ((2 * x) > (y + 15))
                if (x == 0) return -1;
                else
                    Z = Math.Pow((5 + ((Math.Sqrt(y + 5)) / (Math.Pow(x, 3)))), x);
            else
                if (y == 0) return -1;
                else
                    Z = (2 * Math.Pow(x, 2) + 2 * x - (4 + (6 / Math.Pow(y, 2))));
            return Math.Round(Z, 3);
        }
    }
}
