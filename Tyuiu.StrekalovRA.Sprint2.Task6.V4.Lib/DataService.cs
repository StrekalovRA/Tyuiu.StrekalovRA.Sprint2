using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StrekalovRA.Sprint2.Task6.V4.Lib
{
    public class DataService : ISprint2Task6V4
    {
        public string FindCardSuit(int M)
        {
            switch (M) {
                case 1: return "пики";
                case 2: return "трефы";
                case 3: return "бубны";
                case 4: return "червы";
                default: return "-";
            }

            //Хотя, можно и так 😜:
            //string[] Options = new string[] { "пики", "трефы", "бубны", "червы" };
            //if (M>=1 && M <= 4) return Options[M-1];
            //return "-1"
        }
    }
}
