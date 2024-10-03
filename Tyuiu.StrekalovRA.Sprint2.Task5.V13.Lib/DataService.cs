using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StrekalovRA.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int Day = n, Month = m, Year = g;
            // Список дней в месяцах
            int[] Amount_Days_In_Months = new int[12] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            // Определяем последний день текущего месяца
            int Final_Day_In_Month = Amount_Days_In_Months[m - 1];

            // Дефолт
            if (Day != Final_Day_In_Month) { Day += 1; }

            // Случай, если последний день месяца (но не последний месяц в году)
            if (m <= 11 && Day == Final_Day_In_Month) { Day = 1; Month = m + 1; }

            // Случай, если последний день последнего месяца
            if (m == 12 && Day == Final_Day_In_Month) { Day = 1; Month = 1; Year = g + 1; }

            string Date = Convert.ToString(Day) + "/" + Convert.ToString(Month) + "/" + Convert.ToString(Year);
            return Date;
        }
    }
}
