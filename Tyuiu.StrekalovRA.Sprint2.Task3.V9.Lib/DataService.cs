using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StrekalovRA.Sprint2.Task3.V9.Lib
{
    public class DataService : ISprint2Task3V9
    {
        public double Calculate(double x)
        {
            double A;
            if (x == 7 || x == 0) { return -1; } // исключения делений на 0: x ≠ 7

            if (x>0) { A = x * Math.Pow(((x+15)/(x-7)), x); } // x ≠ 7
            else {
                if (x==0) { A = (Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x)); } // A = 1
                else {
                     if (x< 0 && x > -13) { A = Math.Pow((1 + 4 / Math.Pow(x, 2)), x); }
                    else {
                        A = (x + 10 * x + (1 / x));
                    }
                }
            }
            return Math.Round(A, 3);
        }
    }
}
