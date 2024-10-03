using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StrekalovRA.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            // нижняя часть: y от 8 до 15
            if ((x >= 2 && x <= 6) && (y == 14)) return true;
            if ((x >= 3 && x <= 5) && (y == 11)) return true;
            if ((x == 4) && (y >= 8 && y <= 14)) return true;

            if ((x >= 6 && x <= 13) && (y == 8)) return true;
            if ((x >= 6 && x <= 9) && (y == 9)) return true;
            if ((x >= 8 && x <= 9) && (y >=10 && y<=12)) return true;

            // верхняя часть: y от 1 до 8
            if ((x >= 3 && x <= 13) && (y>=5 && y<=7) && (!(x == 13 && y == 5))) return true;
            if ((x >= 3 && x <= 5) && (y >= 3 && y <= 4)) return true;
            if ((x >= 9 && x <= 12) && (y >= 3 && y <= 4)) return true;
            else return false;
        }
    }
}
