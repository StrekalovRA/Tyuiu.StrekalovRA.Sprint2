using Tyuiu.StrekalovRA.Sprint2.Task1.V18.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task0.V6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #2
                Тема: Логические операции
                Задание #1
                Вариант #18
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно
                чередовать, но использовать один раз в выражении) и логических операций
                (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться), а также арифметических
                выражений, которая вернет логическую последовательность(массив):
                (True, True, True, False, True, False), при a = 155, b = 696, c = 242, d = 541
             */

            DataService DS = new DataService();
            var A = DS.GetLogicOperations(155, 696, 242, 541);

            Console.WriteLine("РЕЗУЛЬТАТ:");
            foreach (var o in A) { Console.Write(o + " "); }
            Console.ReadKey();
        }
    }
}