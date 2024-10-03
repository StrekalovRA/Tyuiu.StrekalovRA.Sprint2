using Tyuiu.StrekalovRA.Sprint2.Task5.V13.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task5.V13
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #2
                Тема: Оператор switch
                Задание #5
                Вариант #13
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу, которая использует оператор switch
                вычисляет требуемое значение и возвращает результат.

                Дата некоторого дня характеризуется тремя натуральными числами:
                g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m
                определить дату следующего дня. Заданный год является високосным.
             */

            int G, M, N;
            Console.WriteLine("Year = ");
            G = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Month = ");
            M = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Day = ");
            N = Convert.ToInt32(Console.ReadLine());

            DataService DS = new DataService();
            Console.WriteLine("РЕЗУЛЬТАТ: " + DS.FindDateOfNextDay(G, M, N));
            Console.ReadKey();
        }
    }
}