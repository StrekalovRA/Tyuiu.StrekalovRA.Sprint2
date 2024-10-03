using Tyuiu.StrekalovRA.Sprint2.Task2.V10.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task2.V10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #2
                Тема: Оператор if – полная и короткая форма записи
                Задание #2
                Вариант #10
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу на, которая запрашивает целые значения с клавиатуры и
                вычисляет находится ли точка с координатами X,Y в заштрихованной области.
             */

            int X, Y;
            Console.WriteLine("X = ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y = ");
            Y = Convert.ToInt32(Console.ReadLine());

            DataService DS = new DataService();
            var Bool = DS.CheckDotInShadedArea(X, Y);

            Console.WriteLine("РЕЗУЛЬТАТ: " + Bool);
            Console.ReadKey();
        }
    }
}