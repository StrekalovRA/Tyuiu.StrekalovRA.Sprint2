using System.ComponentModel;
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

            switch (m) // проверка месяца
            {
                case 12: // если последний месяц
                    if (Day == Final_Day_In_Month) {
                        Day = 1; Month = 1; Year = g + 1; // последний день месяца
                    } else {
                        Day += 1; // Дефолт
                    }
                    break;

                default: // если месяц НЕ последний
                    if (Day == Final_Day_In_Month) {
                        Day = 1; Month = m + 1; // последний день месяца
                    } else {
                        Day += 1; // Дефолт
                    }
                    break; // break  здесь не требуется, но выдаёт ошибку :(
            }

            string Day_String = Convert.ToString(Day);
            string Month_String = Convert.ToString(Month);
            string Year_String = Convert.ToString(Year);

            // Добавим "0...", если месяц или день меньше 10
            if (Day < 10) Day_String = "0" + Convert.ToString(Day);
            if (Month < 10) Month_String = "0" + Convert.ToString(Month);

            return Day_String + "." + Month_String + "." + Year_String;
        }
    }
}
