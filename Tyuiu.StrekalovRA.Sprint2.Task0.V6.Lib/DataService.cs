﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.StrekalovRA.Sprint2.Task0.V6.Lib
{
    public class DataService : ISprint2Task0V6
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[] { y == y, x != y, x < y, x > y, x <= y, x >= y };
            return result;
        }
    }
}
