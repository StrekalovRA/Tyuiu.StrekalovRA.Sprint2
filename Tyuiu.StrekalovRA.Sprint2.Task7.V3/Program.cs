using Tyuiu.StrekalovRA.Sprint2.Task7.V3.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task7.V3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #2
                Тема: Оператор if – полная и короткая форма записи
                Задание #7
                Вариант #3
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу на C#, которая запрашивает исходные данные
                (вещественные значения) и вычисляет, находится ли точка
                с координатами X,Y в заштрихованной области.
             */

            double X, Y;
            Console.WriteLine("X = ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y = ");
            Y = Convert.ToDouble(Console.ReadLine());

            DataService DS = new DataService();
            var Arr_Inside = DS.CheckDotInShadedArea(X, Y);

            Console.WriteLine("РЕЗУЛЬТАТ: " + Arr_Inside);
            Console.ReadKey();
        }
    }
}