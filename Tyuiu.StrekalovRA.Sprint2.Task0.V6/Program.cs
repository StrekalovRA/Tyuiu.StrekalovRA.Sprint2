using Tyuiu.StrekalovRA.Sprint2.Task0.V6.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task0.V6
{
    class Program
    {
        public static void  Main (string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #2
                Тема: Операции сравнения
                Задание #0
                Вариант #6
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу из операций сравнений
                (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
                и арифметических выражений, которая вернет логическую
                последовательность(массив): (True, True, True, False, True, False), при x = 107, y = 754
             */

            DataService DS = new DataService();
            var A = DS.GetCompareOperations(104, 754);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            foreach (var o in A) { Console.Write(o + " "); }
            Console.ReadKey();
        }
    }
}