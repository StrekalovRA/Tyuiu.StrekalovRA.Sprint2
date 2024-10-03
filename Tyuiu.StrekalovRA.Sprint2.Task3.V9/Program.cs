using Tyuiu.StrekalovRA.Sprint2.Task3.V9.Lib;

namespace Tyuiu.StrekalovRA.Sprint2.Task3.V9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Стрекалов Р. А. | Смартб-24-1";
            /*
                Спринт #2
                Тема: Вложенные операторы if - else
                Задание #3
                Вариант #9
                Выполнил: Стрекалов Роман Алексеевич | Смартб-24-1

                УСЛОВИЕ:
                Написать программу, которая вычисляет требуемое значение функции Y
                с использованием вложенных оператор if-else, где пользователь вводит
                значение переменной X с клавиатуры. Округлить полученное значение до трех знаков после запятой
             */

            int X;
            Console.WriteLine("X = ");
            X = Convert.ToInt32(Console.ReadLine());

            DataService DS = new DataService();
            var Z = DS.Calculate(X);

            Console.WriteLine("РЕЗУЛЬТАТ: " + Z);
            Console.ReadKey();
        }
    }
}